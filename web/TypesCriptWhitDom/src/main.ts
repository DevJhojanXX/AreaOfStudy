
const app:HTMLElement = <HTMLElement> document.getElementById('app');

const header = new Header('Hello');
app.innerHTML = header.render();


// const fetchHTMLFile =  new FetchHTMLFile(); // como el index.html ya lo tiene como script, no es necesario importar la clase

// fetchHTMLFile.findFile('./scripts/prueba.html').then(htmlString => {
//   app.innerHTML = htmlString;
// });



// const data = {
//     name: "Juan",
//     age: 30
// };

// const userInfo = `
//     <div>
//         <h2>${data.name}</h2>
//         <p>Edad: ${data.age}</p>
//     </div>
// `;

// app.innerHTML = userInfo;

// Uso de la función para cargar un archivo HTML y convertirlo en una cadena
 