using ConsoleApp_12B_26C2_Consultas;

Console.WriteLine("INICIO");


Estudiante[] Estudiantes() =>
    new Estudiante[]
    {
        new Estudiante { Id = 1, Nombre = "Juan", Edad = 20 },
        new Estudiante { Id = 2, Nombre = "María", Edad = 22 },
        new Estudiante { Id = 3, Nombre = "Pedro", Edad = 14 },
        new Estudiante { Id = 4, Nombre = "Ana", Edad = 16 },
        new Estudiante { Id = 5, Nombre = "Luis", Edad = 23 },
        new Estudiante { Id = 6, Nombre = "Mariel", Edad = 17 },
        new Estudiante { Id = 7, Nombre = "Gisela", Edad = 27 },
        new Estudiante { Id = 8, Nombre = "Fernando", Edad = 31 },
        new Estudiante { Id = 9, Nombre = "Martin", Edad = 18 },
        new Estudiante { Id = 10, Nombre = "Ariela", Edad = 18 }
    };

Console.WriteLine("filtramos alumnos su por edad");
Estudiante[] salidaProceso = new Estudiante[10];
int conta = 0;
foreach (var item in Estudiantes())
{
    if (item.Edad >= 13 && item.Edad <= 18)
    {
        salidaProceso[conta] = item;
        conta++;
    }
}

for (int i = 0; i < conta; i++)
{
    Console.WriteLine($"Id: {salidaProceso[i].Id}, Nombre: {salidaProceso[i].Nombre}, Edad: {salidaProceso[i].Edad}");
}


Console.WriteLine("filtramos alumnos su por edad con LinQ");
// EXPRESION DE CONSULTA - QUERY EXPRESSIONS - SELECT * FROM ESTUDIANTES WHERE EDAD >= 18 AND EDAD <= 18

var consutlaLinQ1 = from estu in Estudiantes() where estu.Edad >= 13 && estu.Edad <= 18
                    select estu;

foreach (var pepe in consutlaLinQ1)
{
    Console.WriteLine($"Id: {pepe.Id}, Nombre: {pepe.Nombre}, Edad: {pepe.Edad}");
}


Console.WriteLine("filtramos alumnos su por edad con LinQ - METODOS DE EXTENSION - EXPRESIONES LAMBDA");
var consultaLinQ2 = Estudiantes().Where(estu => estu.Edad >= 13 && estu.Edad <= 18).OrderBy(estu => estu.Nombre);
foreach (var pepe in consultaLinQ2)
{
    Console.WriteLine($"Id: {pepe.Id}, Nombre: {pepe.Nombre}, Edad: {pepe.Edad}");
}