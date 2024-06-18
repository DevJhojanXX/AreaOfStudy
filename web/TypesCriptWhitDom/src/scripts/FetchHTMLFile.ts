class FetchHTMLFile {
  constructor() {
  }
  async findFile(filePath: string): Promise<string> {
    try {
      // Realizar la solicitud para obtener el archivo HTML
      const response = await fetch(filePath);

      // Verificar si la solicitud fue exitosa
      if (!response.ok) {
        throw new Error(
          `Error al cargar el archivo HTML: ${response.statusText}`
        );
      }
      // Leer el contenido del archivo como texto
      const htmlString = await response.text();
      return htmlString;
    } catch (error) {
      console.error("Error al cargar el archivo HTML:", error);
      return ""; // Retornar una cadena vacía en caso de error
    }
  }
}
