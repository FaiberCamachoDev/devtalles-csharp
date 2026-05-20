using TM = TaskMaster;

partial class Program
{
    public static void TaskMaster()
    {
        string filePath = "./06-TaskMaster/task.json";
        var fileActions = new TM.FileActions<TM.Task>(filePath);
        List<TM.Task> tasks = fileActions.ReadFile();
        var queries = new TM.Queries(tasks);

        bool salir = false;
        while (!salir)
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\n====== TaskMaster ======");
            ResetColor();
            WriteLine("1. Listar tareas");
            WriteLine("2. Añadir tarea");
            WriteLine("3. Marcar tarea como completada");
            WriteLine("4. Editar tarea");
            WriteLine("5. Eliminar tarea");
            WriteLine("6. Consultar tareas por estado");
            WriteLine("7. Consultar tarea por descripción");
            WriteLine("8. Salir");
            Write("\nSeleccione una opción: ");

            Action accion = ReadLine() switch
            {
                "1" => () => queries.ListTasks(),
                "2" => () =>
                {
                    Write("Descripción de la nueva tarea: ");
                    string desc = ReadLine()!;
                    queries.AddTask(desc);
                    fileActions.WriteFile(tasks);
                },
                "3" => () =>
                {
                    queries.ListTasks();
                    Write("ID de la tarea a completar: ");
                    string id = ReadLine()!;
                    queries.MarkAsCompleted(id);
                    fileActions.WriteFile(tasks);
                },
                "4" => () =>
                {
                    queries.ListTasks();
                    Write("ID de la tarea a editar: ");
                    string id = ReadLine()!;
                    Write("Nueva descripción: ");
                    string desc = ReadLine()!;
                    queries.EditTask(id, desc);
                    fileActions.WriteFile(tasks);
                },
                "5" => () =>
                {
                    queries.ListTasks();
                    Write("ID de la tarea a eliminar: ");
                    string id = ReadLine()!;
                    queries.RemoveTask(id);
                    fileActions.WriteFile(tasks);
                },
                "6" => () =>
                {
                    Write("Estado a consultar (1. Completadas / 2. Pendientes): ");
                    bool completed = ReadLine() == "1";
                    queries.TasksByState(completed);
                },
                "7" => () =>
                {
                    Write("Palabra clave a buscar: ");
                    string keyword = ReadLine()!;
                    queries.TasksByDescription(keyword);
                },
                "8" => () => { salir = true; Console.Clear(); },
                _   => () => { ForegroundColor = ConsoleColor.Yellow; WriteLine("Opción no válida."); ResetColor(); }
            };

            accion();

            if (!salir)
            {
                WriteLine("\nPresione cualquier tecla para continuar...");
                ReadKey();
                Console.Clear();
            }
        }
    }
}
