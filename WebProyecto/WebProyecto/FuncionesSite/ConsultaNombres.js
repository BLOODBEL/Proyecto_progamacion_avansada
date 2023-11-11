function ConsultarNombre() {
    let identificacion = $("#Identificacion").val();

    if (identificacion.length > 0) {
        $.ajax({
            url: 'https://apis.gometa.org/cedulas/' + identificacion,
            type: "GET",
            success: function (data) {
                // Verifica si la respuesta tiene la propiedad 'nombre'
                if (data && data.nombre) {
                    // Establece el valor del campo con el nombre obtenido de la API
                    $("#Nombre").val(data.nombre);
                } else {
                    // Si la propiedad 'nombre' no está presente en la respuesta, maneja el caso en consecuencia
                    console.error("La propiedad 'nombre' no está presente en la respuesta de la API.");
                }
            },
            error: function (xhr, status, error) {
                // Manejo de errores, por ejemplo, puedes mostrar un mensaje al usuario o registrar el error en la consola
                console.error("Error al realizar la solicitud a la API:", status, error);
            }
        });
    } else {
        // Si la identificación está vacía, borra el valor del campo de nombre
        $("#Nombre").val("");
    }
}
