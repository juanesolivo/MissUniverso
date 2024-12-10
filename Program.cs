using System.Data.SqlClient;

SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jimif\\Documents\\Code\\DessarrolloSoftwareIII\\MissUniverso\\DataMissUniverso.mdf;Integrated Security=True");
connection.Open();
SqlCommand cmd = connection.CreateCommand();

string nombres, apellidos, tipoDocumento, documento, colorPelo, colorPiel, dimensiones, provincia, descripcion, fechaNacimiento;
int estatura, estado;
while (true)
{
    Console.WriteLine("MISS UNIVERSO APP");
    Console.WriteLine();
    Console.Write("Ingrese el nombre de la concursante: ");
    nombres = Console.ReadLine();
    Console.Write("Ingresa los apellidos de la concursante: ");
    apellidos = Console.ReadLine();
    Console.Write("Ingrese el tipo de documento de la concursante: ");
    tipoDocumento = Console.ReadLine();
    Console.Write("Ingrese el documento de la concursante: ");
    documento = Console.ReadLine();
    Console.Write("Ingrese la estatura de la concursante (en cm): ");
    estatura = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el color de pelo de la concursante: ");
    colorPelo = Console.ReadLine();
    Console.Write("Ingrese el color de piel de la concursante: ");
    colorPiel = Console.ReadLine();
    Console.Write("Ingrese las dimensiones de la concursante (00-00-00): ");
    dimensiones = Console.ReadLine();
    Console.Write("Ingresa la provincia de la concursante: ");
    provincia = Console.ReadLine();
    Console.Write("Brinde una descripcion de la concursante: ");
    descripcion = Console.ReadLine();
    Console.Write("Ingrese la fecha de nacimiento de la concursante (00/00/0000): ");
    fechaNacimiento = Console.ReadLine();
    Console.Write("Ingresa el estado de la concursante \n1- Concursando\n2- Descalificada\n3- Ganadora\n: ");
    estado = int.Parse(Console.ReadLine());
    cmd.CommandText = "INSERT INTO tblCandidatas" +
        "(nombres, apellidos, tipoDocumento, documento, estatura, colorPelo, colorPiel, dimensiones, provincia, descripcion, fechaNacimiento, estado)" +
        "VALUES" +
        $"('{nombres}', '{apellidos}', '{tipoDocumento}','{documento}', {estatura}, '{colorPelo}', '{colorPiel}', '{dimensiones}', '{provincia}', '{descripcion}', '{fechaNacimiento}', {estado})";
    cmd.ExecuteNonQuery();
}
