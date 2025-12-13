# Sistema-de-Registro-de-Empleados
 🎯Un Sistema de Registro de Empleados (SRE) es una herramienta (generalmente un software, parte de un sistema de Información de Recursos Humanos o HRIS) diseñada para centralizar, organizar y gestionar toda la información relevante de los trabajadores de una organización. 

 La BD esta realizada en SQL SERVER 
 TBL + DATOS + SP 


SISTEMA DE REGISTRO DE EMPLEADOS



DATAEMPLEO S.A
01/10/2025
AUTORES
Rosmery Herrera
Josué Mayrena
Josseling Gutiérrez	




Contents
SISTEMA DE REGISTRO DE EMPLEADOS	1
DATAEMPLEO S.A	1
01/10/2025	1
AUTORES	1
INTRODUCCION	3
Objetivo General	4
Objetivo Especifico	4
Requerimientos Funcionales	4
Requerimientos no Funcionales	5
Factibilidad técnica	6
Factibilidad económica	7
Factibilidad Operativo	7


























INTRODUCCION

En la actualidad, la gestión eficiente es un factor fundamental para el buen funcionamiento de cualquier organización. Las empresas requieren mantener un control preciso sobre la información de sus empleados, tales como datos personales, cargos, departamentos, asistencia y estado laboral. Sin embargo, cuando este proceso se realiza de forma manual (Hoja de papel), suelen presentarse problemas como pérdida de información, duplicidad de datos, lentitud en las consultas y dificultad para generar reportes actualizados.

Ante esta necesidad, surge la implementación de un Sistema de Registro de Empleados, el cual permite automatizar y centralizar toda la información relacionada con el personal de una empresa. Este sistema tiene como propósito facilitar la administración de los datos de los empleados mediante el uso de una base de datos estructurada y una interfaz interactiva que permita registrar, modificar, eliminar y consultar la información de manera rápida y segura.

El desarrollo de este sistema contribuye significativamente a optimizar los procesos administrativos, mejorar la toma de decisiones y garantizar la integridad de los datos. Además, proporciona herramientas que permiten un seguimiento más eficiente del desempeño y asistencia de los empleados, fortaleciendo así la organización y el control interno dentro de la institución.





Objetivo General

Desarrollar un Sistema de Registro de Empleados que permita administrar de manera eficiente la información del personal .

Objetivo Especifico 

•	Diseñar y estructurar una base de datos que almacene de forma organizada la información de los empleados, incluyendo datos personales.

•	Implementar una interfaz de usuario funcional que permita realizar operaciones de registro, modificación, eliminación y búsqueda de empleados de manera sencilla, segura y accesible para los administradores.

•	Optimizar el proceso de gestión del personal, reduciendo el tiempo y los errores en la manipulación de la información


Requerimientos: 
Requerimientos Funcionales 

Numero 	Requerimiento 	Descripcion 	Prioridad 
RF01 	Registro de empleados	Permitir registrar nuevos empleados.
RF02 	Consulta de empleados	permitir buscar y visualizar los datos de un empleado utilizando criterios: Nombre y departamento.	 
RF03 	Modificación de datos	El sistema debe permitir editar la información de un empleado previamente registrado	 
RF04 	Eliminación de registros
	El sistema debe permitir eliminar un registro de empleado	 
RF05 	Control de acceso	El sistema debe requerir inicio de sesión para poder acceder.	 
 RF06	 Usabilidad	El sistema debe tener una interfaz intuitiva y fácil de usar para usuarios con conocimientos básicos en informática.	 


Requerimientos no Funcionales 

Numero 	Requerimiento 	Descripcion 	Prioridad 
RNF01 	Portabilidad	El sistema debe ser compatible y funcionar correctamente en sistemas operativos Windows 10	 
RNF02 	Integridad	El sistema debe validar los campos al momento de registro para evitar duplicar datos.	 
RNF03 	Usabilidad 	La interfaz debe ser intuitiva y fácil de usar sin conocimientos técnicos avanzados.	 
RNF04 	Seguridad 	Se debe implementar un sistema de usuarios con contraseñas parar	 
RNF05	Control de Acceso	El sistema debe requerir que la contraseña de inicio de sesión.	
RNF05 	Documentación	Accesibilidad para administradores con conocimientos básicos.	 


Estudio de factibilidad: 
Factibilidad técnica  

En esta opción se compra una computadora adecuada para la instalación del sistema dejando configurado Cliente Servidor esto con la finalidad de ahorrar recurso y adaptarse al presupuesto. 

Se utiliza C# para el desarrollo del sistema debido a su compatibilidad con Windows y su amplia integración con SQL Server. 

	Plataforma de Desarrollo y Lenguaje 
	
Lenguaje 		C# 
Plataforma 		Visual Studio 2022

Se utilizará Windows Forms NET Framework para desarrollar la interfaz de usuario del sistema, aprovechando su facilidad de uso y la familiaridad con el entorno Windows. 
	Interfaz de Usuario 
Interfaz 		NET Framework
Responsive 		interfaz gráfica sencilla y amigable para el administrador
Se utilizara Microsoft SQL Server como el sistema de gestión de base de datos. 

Factibilidad económica  

En las siguientes tablas analizaremos el valor económico del recurso mencionado anteriormente. Correspondiente al Factibilidad técnica #1. 

# 	Nombre del Recurso 	Valor económico ($) 
1 	Visual studio y Licencia  	$ 0.00 
2 	SQL Server y licencia  	$ 0.00 
3 	Laptop (1) 	$500 
4 	Asistencia Full Stack (2) 	$900
5 	antivirus 	$15
6 	Analista de sistemas (1) 	$600 
 	Total 	$2,015

# 	Nombre del Recurso 	Valor económico ($) 	 
1 	Visual studio y Licencia  	$ 0.00 	 
2 	Laptop (1) 	$00.00 	 
3 	Asistencia Full Stack (2) 	$00.00 	 
4 	Analista de sistemas (1) 	$00.00	 
5 	antivirus 	$00.00	 
6 	Oracle 	$00.00 	 
 	Total 	$00.00 	 


Factibilidad Operativo  

El sistema busca automatizar el proceso de registro, actualización y consulta de información de los empleados, sustituyendo los métodos manuales que actualmente se utilizan (como hojas de cálculo o documentos físicos).



Factores Humanos y Organizacionales

El personal administrativo y de recursos humanos será el único usuario del sistema. Ellos cuentan con conocimientos básicos en el manejo de computadoras, lo que facilita la adopción del nuevo sistema.


Compatibilidad con los Procesos Actuales

El sistema se adapta de manera eficiente a los procesos actuales del área de Recursos Humanos, reemplazando las tareas manuales sin alterar significativamente el flujo de trabajo existente.
Además, permitirá una mejor organización y acceso rápido a la información de los empleados.


Evaluación Final
El proyecto es operativamente factible, ya que:
•	El personal puede adaptarse fácilmente al sistema.
•	No se requiere una reestructuración organizacional.
•	Se aprovecha la infraestructura existente.
•	Se mejora la eficiencia y precisión del registro de empleados.


20 caso USO

•	Registrar empleado: El administrador añade un nuevo empleado al sistema.
•	Ver empleados: El administrador ve la lista de todos los empleados.
•	Buscar empleado: El administrador busca un empleado por su nombre.
•	Buscar por departamento: El administrador busca empleados de un departamento específico.
•	Modificar empleado: El administrador actualiza la información de un empleado.
•	Eliminar empleado: El administrador elimina a un empleado del sistema.
•	Iniciar sesión: El administrador accede al sistema con su usuario y contraseña.
•	Cerrar sesión: El administrador sale de la sesión de forma segura.
•	Funcionalidades administrativas adicionales
•	Añadir departamento: El administrador crea un nuevo departamento.
•	Editar departamento: El administrador cambia el nombre de un departamento.
•	Eliminar departamento: El administrador borra un departamento.
•	Asignar empleado a departamento: El administrador asigna un empleado a un departamento.
•	Ver detalles del empleado: El administrador ve toda la información de un empleado en particular.
•	Gestionar usuarios: El administrador gestiona las cuentas de acceso de otros administradores.
•	Cambiar contraseña: El administrador cambia su propia contraseña.
•	Generar reporte simple: El administrador genera un informe básico de empleados.
•	Interacción del sistema
•	Validar usuario: El sistema verifica que las credenciales de inicio de sesión sean correctas.
•	Validar datos: El sistema comprueba que los datos ingresados sean válidos (evitar duplicados).

Diagrama Entidad Relacion

 















	


Diagrama de Clase 


 


Diagrama de Gantt 
 

