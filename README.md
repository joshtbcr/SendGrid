# SendGrid
Tutorial para integrar el API de SendGrid con .NET

¿Qué es el servicio de correo electrónico SendGrid?

SendGrid es un servicio de correo electrónico basado en la nube que proporciona entrega confiable de correo electrónico transaccional , escalabilidad y análisis en tiempo real junto con API flexibles que facilitan la integración personalizada. 
Los escenarios de uso comunes de SendGrid incluyen:

•	Envío automático de recibos a clientes.
•	Administrar listas de distribución para enviar a los clientes volantes electrónicos mensuales y ofertas especiales.
•	Recopilar métricas en tiempo real para cosas como correo electrónico bloqueado y capacidad de respuesta del cliente.
•	Generando informes para ayudar a identificar tendencias.
•	Reenviar consultas de clientes.
•	Notificaciones por correo electrónico desde su aplicación.

Para registrarse en una cuenta SendGrid:

•	Debe ingresar a la página principal de twilio sendgrid.
•	Dar click al botón start for free para comenzar.
•	Debe dirigirse a la opción gratuita.
•	Debe ingresar sus datos en el formulario.
•	Luego nos direcciona a un nuevo formulario el cual debemos ingresar de nuevo la información e iniciamos.

Para encontrar su clave API SendGrid
1.	Haz clic en settings.
2.	En su panel de SendGrid, seleccione API Keys.
3.	Haz clic en Crear clave de API. 
4.	Como mínimo, proporcione el Nombre de esta clave y proporcione acceso completo a Enviar correo y seleccione Guardar.
5.	Su API se mostrará en este momento una vez. Asegúrese de guardarlo de manera segura.

Solo puede enviar hasta 100 correos electrónicos / día hasta que haya verificado su cuenta.

Iniciar en Visual Studio:

•	Se crea un proyecto de tipo console application.
•	En la variable sendgridClient guardamos la clave que nos proporcionó SendGrid.
•	Se crea una variable from de tipo emailAddress, del cual será enviado el correo.
•	Se crea una variable subject, el cual contiene el encabezado del correo.
•	Se crea una variable to tipo emailAddress, el cual va a ser a quién se l enviará el correo.
•	Se crea una variable plainContent y la variable de html.
•	Se crea una variable msg, el cual va a contener en to,from,subject,plainContent y el html.
•	Se crea una variable response, el cual tendrá la variable msg.

Ejecutar Acción:

1.	Presionar la opción start para proceder a correr el programa.
2.	Seleccionar la opción iniciar. 

Pruebas:

1.	Ingresar al correo electrónico que incluyo en el código.
2.	Ingresar a la opción de spam.
3.	Refrescar la página.
