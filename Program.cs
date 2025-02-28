// Esta función crea un archivo llamado inventos si es que no existe, si existe solo muestra un mensaje, además al crear el archivo le agrega una linea de texto
void CrearArchivo(){
    string path = "c:/Progra1/Laboratorio4/inventos.txt";
    try {
        if(!File.Exists(path)){
            string contenido = "Traje Mark I";
            File.WriteAllText(path,contenido);
            Console.WriteLine("Archivo Creado");
        } else {
            Console.WriteLine("El archivo ya existe.");
        }
    }catch(DirectoryNotFoundException err){
        Console.WriteLine("No existe el directorio " + path);
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función permite agregar lineas al archivo, sin remplazar el contenido que tenga
void AgregarLineas(){
    string path = "c:/Progra1/Laboratorio4/inventos.txt";
    try{
        if(File.Exists(path)){
            string contenido;
            Console.WriteLine("Agregar nuevo invento: ");
            contenido = Console.ReadLine();
            File.AppendAllText(path,$"\n{contenido}");
            Console.WriteLine("Invento Agregado");
        }else{
            Console.WriteLine("El archivo no existe");
        }
    }catch(DirectoryNotFoundException){
        Console.WriteLine("No existe el directorio " + path);
    }catch(FileNotFoundException){
        Console.WriteLine("El archivo no existe");
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función lee el archivo linea por linea, lo que permite que sea enumerado
void LeerArchivoLinea(){
    string path = "c:/Progra1/Laboratorio4/inventos.txt";
    try {
        if(File.Exists(path)){
            string[] lineas  = File.ReadAllLines(path);
            int i = 0;
            foreach(string linea in lineas){
                Console.WriteLine($"Linea Numero {i++}: " + linea);
            }
        } else {
            Console.WriteLine("El archivo no existe");
        }
    }catch(DirectoryNotFoundException){
        Console.WriteLine("No existe el directorio " + path);
    }catch(FileNotFoundException){
        Console.WriteLine("El archivo no existe");
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función lee el archivo por completo y lo muestra
void LeerArchivo(){
    string path = "c:/Progra1/Laboratorio4/inventos.txt";
    try {
        string contenido = File.ReadAllText(path);
        Console.WriteLine(contenido);
    }catch(DirectoryNotFoundException){
        Console.WriteLine("No existe el directorio " + path);
    }catch(FileNotFoundException){
        Console.WriteLine("El archivo no existe");
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función copia un archivo a un directorio (carpeta)
void CopiarArchivo(){
    string pathOrigen = "c:/Progra1/Laboratorio4/inventos.txt";
    string pathDestino = "c:/Progra1/Laboratorio4/Backup/inventos.txt";

    try{
        File.Copy(pathOrigen,pathDestino);
        Console.WriteLine("Se ha copiado el archivo");
    }catch(DirectoryNotFoundException){
        Console.WriteLine("No existe el directorio ");
    }catch(FileNotFoundException){
        Console.WriteLine("El archivo no existe");
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función elimina el archivo de texto, se utiliza despues de copiar el archivo
void EliminarArchivo(){
    string path = "c:/Progra1/Laboratorio4/inventos.txt";
    try {
        if(File.Exists(path)){
            File.Delete(path);
            Console.WriteLine("Archivo eliminado " + path);
        } else {
            Console.WriteLine("El archivo no existe");
        }
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función mueve un archivo, y si falla la ruta prueba con otra ruta.
void MoverArchivo(){
    string pathOrigen = "c:/Progra1/Laboratorio4/inventos.txt";
    string pathOrigen2 = "c:/Progra1/Laboratorio4/Backup/inventos.txt";
    string pathDestino = "c:/Progra1/Laboratorio4/ArchivosClasificados/inventos.txt";

    try{
        File.Move(pathOrigen,pathDestino);
        Console.WriteLine("Se ha movido el archivo");
    }catch(DirectoryNotFoundException){
        Console.WriteLine("No existe el directorio ");
    }catch(FileNotFoundException){
        File.Move(pathOrigen2,pathDestino);
        Console.WriteLine("Se ha movido el archivo");
        // Console.WriteLine("El archivo no existe");
    }catch(Exception err){
        Console.WriteLine("Otro error: " + err);
    }
}

// Esta función crea una carpeta llamada ProyectosSecretos
void CrearCarpeta(){
    string path = "c:/Progra1/Laboratorio4/ProyectosSecretos";
    try {
        Directory.CreateDirectory(path);
        Console.WriteLine("Carpeta creada: " + path);
    } catch (Exception err) {
        Console.WriteLine("Error al crear la carpeta: " + err);
    }
}

// Esta función lista los archivos que se encuentran en la carpeta principal
void ListarArchivos(){
    string path = "c:/Progra1/Laboratorio4";
    try {
        if (Directory.Exists(path)) {
            string[] archivos = Directory.GetFiles(path);
            Console.WriteLine("Archivos en la carpeta principal:");
            foreach (string archivo in archivos) {
                Console.WriteLine(Path.GetFileName(archivo));
            }
        } else {
            Console.WriteLine("El directorio no existe.");
        }
    } catch (Exception err) {
        Console.WriteLine("Otro error: " + err);
    }
}

void Menu(){
    int opcion;
    do {
        try {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear Archivo");
            Console.WriteLine("2. Agregar Lineas");
            Console.WriteLine("3. Leer Archivo por Linea");
            Console.WriteLine("4. Leer Archivo Completo");
            Console.WriteLine("5. Copiar Archivo");
            Console.WriteLine("6. Mover Archivo");
            Console.WriteLine("7. Crear Carpeta");
            Console.WriteLine("8. Listar Archivos");
            Console.WriteLine("9. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion) {
                case 1:
                    CrearArchivo();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 2:
                    AgregarLineas();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 3:
                    LeerArchivoLinea();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 4:
                    LeerArchivo();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 5:
                    CopiarArchivo();
                    EliminarArchivo();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 6:
                    MoverArchivo();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 7:
                    CrearCarpeta();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 8:
                    ListarArchivos();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } catch (FormatException) {
            Console.WriteLine("Entrada no válida, por favor ingrese un número.");
            opcion = 0; 
        }
    } while(opcion != 9);
}
Menu();
