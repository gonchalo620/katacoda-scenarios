Con la referencia de la dependencia Newtonsoft.Json ya agregada al proyecto, vamos a hacer uso de la misma.

Abra el archivo Program.cs y agregue el siguiente código antes de: class Program

```
public class Account
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DOB { get; set; }
}
```{{copy}}

Luego reemplace la función static void Main(string[] args) con la siguiente porción de código:

```
static void Main(string[] args)
{
    Account account = new Account
    {
        Name = "Jhon Jairo Perez",
        Email = "john@email.com",
        DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
    };

    string json = JsonConvert.SerializeObject(account, Formatting.Indented);
    Console.WriteLine(json);
}
```{{copy}}

Ahora ejecuta la aplicación `dotnet run`{{execute}}. Debe ver en la consola algo como esto:

```
{
  "Name": "Jhon Jairo Perez",
  "Email": "john@email.com",
  "DOB": "1980-02-20T00:00:00Z"
}
```