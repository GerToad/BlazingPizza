# BlazingPizza

## Coceptos
En Blazor, los eventos se utilizan para responder a las acciones del usuario o para notificar a los componentes de los cambios en el estado de la aplicación. Los eventos en Blazor son similares a los eventos en otras plataformas web, como JavaScript.

Un evento en Blazor se define en el marcado Razor de un componente utilizando la sintaxis @on{eventname}={metodohandler}. Por ejemplo, para manejar el evento click de un botón, podemos agregar la siguiente línea de código en el marcado Razor del botón:


`<button @onclick="HandleClick">Click me</button>`

En este ejemplo, @onclick es el nombre del evento que se está manejando, y HandleClick es el nombre del método en el componente que manejará el evento.

El método manejador del evento en Blazor debe estar en el archivo de código fuente (.cs o .razor) del componente y debe tener la firma adecuada para el evento que está manejando. Por ejemplo, para manejar el evento click, el método debe tener la siguiente firma:


`private void HandleClick()`
`{`
    `// Código para manejar el evento click`
`}`

En este método, podemos escribir la lógica que queremos ejecutar cuando el botón es clickeado.

En resumen, los eventos en Blazor se utilizan para responder a las acciones del usuario o para notificar a los componentes de los cambios en el estado de la aplicación. Se definen en el marcado Razor del componente y se manejan en un método en el archivo de código fuente del componente.

## Otros
Al usar la version 5 de .Net los paquetes para la base de datos se tenian que cargar en la version 5 como el Framework Core y Sql Server
