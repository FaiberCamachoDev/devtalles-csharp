# Serialización y Deserialización de JSON en C#

En .NET se usa el namespace `System.Text.Json` (incluido desde .NET 5+).  
No necesitas instalar ningún paquete adicional.

---

## Conceptos clave

| Término | Qué significa |
|---|---|
| **Serializar** | Convertir un objeto C# → texto JSON |
| **Deserializar** | Convertir texto JSON → objeto C# |

---

## 1. Serializar un objeto a JSON

```csharp
var options = new JsonSerializerOptions { WriteIndented = true };
string json = JsonSerializer.Serialize(miObjeto, options);
```

- `WriteIndented = true` genera JSON con sangría (más legible).
- Sin opciones, el JSON sale en una sola línea (más compacto, útil en producción).

---

## 2. Guardar JSON en un archivo

```csharp
File.WriteAllText("./ruta/archivo.json", json);
```

Combinas `JsonSerializer.Serialize` con `File.WriteAllText`.  
Si el archivo no existe, lo crea. Si existe, lo sobreescribe.

---

## 3. Deserializar desde archivo

```csharp
string jsonFromFile = File.ReadAllText("./ruta/archivo.json");
var lista = JsonSerializer.Deserialize<List<Character>>(jsonFromFile);
```

El tipo genérico `<List<Character>>` le dice a .NET en qué tipo convertir el JSON.  
El `!` (null-forgiving) se usa porque `Deserialize` puede retornar null si el JSON es inválido.

---

## 4. Deserializar un objeto individual

```csharp
string singleJson = """{"Id":1,"Name":"Peter Parker","Alias":"Spider-Man","Team":"Avengers"}""";
var character = JsonSerializer.Deserialize<Character>(singleJson);
```

Las `"""` son raw string literals de C# 11, útiles para escribir JSON sin escapar comillas.

---

## 5. Agregar o modificar y volver a guardar

```csharp
lista.Add(new Character { Id = 4, Name = "Bruce Banner", Alias = "Hulk", Team = "Avengers" });
File.WriteAllText(jsonPath, JsonSerializer.Serialize(lista, options));
```

El flujo siempre es: **deserializar → modificar en memoria → serializar → guardar**.

---

## 6. JsonSerializerOptions más usadas

```csharp
var options = new JsonSerializerOptions
{
    WriteIndented = true,                                      // JSON con sangría
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,        // propiedades en camelCase
    PropertyNameCaseInsensitive = true,                       // ignora mayúsculas al deserializar
};
```

---

## Flujo completo resumido

```
Objeto C#  →  JsonSerializer.Serialize()   →  string JSON  →  File.WriteAllText()  →  .json en disco
   ↑                                                                                        ↓
   └──  JsonSerializer.Deserialize<T>()  ←  string JSON  ←  File.ReadAllText()  ←────────┘
```
