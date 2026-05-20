using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private readonly List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            var active = Tasks.Where(t => !t.Deleted).ToList();
            if (active.Count == 0) { WriteLine("No hay tareas registradas."); return; }
            PrintTable(active);
        }

        public void AddTask(string description)
        {
            string id = Guid.NewGuid().ToString()[..7];
            Tasks.Add(new Task(id, description));
        }

        public void MarkAsCompleted(string id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id && !t.Deleted);
            if (task is null) { ForegroundColor = ConsoleColor.Red; WriteLine("Tarea no encontrada."); ResetColor(); return; }
            task.Completed = true;
            task.ModifiedAt = DateTime.Now;
        }

        public void EditTask(string id, string newDescription)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id && !t.Deleted);
            if (task is null) { ForegroundColor = ConsoleColor.Red; WriteLine("Tarea no encontrada."); ResetColor(); return; }
            task.Description = newDescription;
            task.ModifiedAt = DateTime.Now;
        }

        public void RemoveTask(string id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id && !t.Deleted);
            if (task is null) { ForegroundColor = ConsoleColor.Red; WriteLine("Tarea no encontrada."); ResetColor(); return; }
            task.Deleted = true;
            task.ModifiedAt = DateTime.Now;
        }

        public void TasksByState(bool completed)
        {
            var filtered = Tasks.Where(t => !t.Deleted && t.Completed == completed).ToList();
            if (filtered.Count == 0) { WriteLine("No hay tareas con ese estado."); return; }
            PrintTable(filtered);
        }

        public void TasksByDescription(string keyword)
        {
            var filtered = Tasks
                .Where(t => !t.Deleted && t.Description!.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
            if (filtered.Count == 0) { WriteLine("No se encontraron tareas con esa descripción."); return; }
            PrintTable(filtered);
        }

        private static void PrintTable(List<Task> tasks)
        {
            var table = new Table(new TableConfiguration(Style.Unicode), "ID", "Descripción", "Estado", "Creada", "Modificada");
            foreach (var t in tasks)
            {
                table.AddRow(
                    t.Id!,
                    t.Description!,
                    t.Completed ? "Completada" : "Pendiente",
                    t.CreatedAt.ToString("yyyy-MM-dd"),
                    t.ModifiedAt.ToString("yyyy-MM-dd HH:mm")
                );
            }
            Write(table.ToString());
        }
    }
}
