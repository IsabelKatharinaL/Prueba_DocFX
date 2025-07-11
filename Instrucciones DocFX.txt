Instrucciones DocFX

1. Habilitar la documentación XML en vbproj

  <GenerateDocumentationFile>true</GenerateDocumentationFile>
  <NoWarn>1591</NoWarn>
  <!-- Opcional: oculta warnings por miembros no documentados -->

2. Comentar los que queramos  siguiendo el estándar xml


    ''' <summary>
    ''' Función pública que pide una tabla de datos a Odoo
    ''' </summary>
    ''' <param name="modelo">Modelo del que pedimos los datos</param>
    ''' <param name="listaDomain">Filtros de búsqueda</param>
    ''' <param name="listaCampos">Campos que queremos mostrar</param>
    ''' <returns>Tabla</returns>


3. Compilar el proyecto. Esto generará un documento XML en la carpeta bin.

4. Instalar DocFX. Desde Command: choco install docfx -y
	o desde GitHub: https://github.com/dotnet/docfx/releases
	--> Esto hay que hacerlo como administrador. Para comprobar que se ha instalado bien, ponemos lo siguiente en cmd: docfx --versión

	--> Hay que añadirlo en el PATH de variables de entorno

5. Para arrancar docfx, en cmd, navegamos hasta la carpeta donde queremos generar la documentación y ejecutamos docfx de la siguiente manera:
	..\Desktop\Prueba_DocFX\Docs>docfx.exe init

7. Configuramos la página


	Name (mysite): UtilsOdoo
	Generate .NET API documentation? [y/n] (y): n
	Markdown docs location (docs): docs
	Enable site search? [y/n] (y): y
	Enable PDF? [y/n] (y): y

8. Cuando nos pregunte si esto está OK, decimos que sí y ejecutamos: docfx ..\Prueba_DocFX\Docs\docfx.json --serve 
	--> Hay que poner la ruta completa del json


--

Incluir documentación de .NET

1.Añadir o modificar la sección "metadata" en el json, debemos indicar la .dll de nuestro proyecto.
	--> Para que no de problemas en la ruta ("cwd"), lo más recomendable es mover los ficheros (dll, XML) dentro de la carpeta donde se está generando la documentación



2 Ponemos el localhost que nos indique en el navegador.