using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Sistema
{
	class Mensajes
	{
		internal const string TITULO_ERROR_SESION = "Error de Inicio de Sesión";
		internal const string ERROR_SESION = "El usuario o la contraseña es incorrecta.";
		internal const string Confirmacion = "Confirmación";
		internal const string DescripcionConfirmacion = "Se modificarán los datos.\n¿Estás seguro de realizar este proceso.?";
		internal const string TituloSuccess = "Felicidades";
		internal const string DescripcionSuccessModificacion = "Se modificaron los datos correctamente";
		internal const string TituloError = "Error";
		internal const string DescripcionError = "Ocurrió un problema.\n";
		internal const string Advertencia = "Advertencia";
		internal const string DescripcionFiltrosGrid = "No existen datos para mostrar.\nDebes seleccionar un tipo de busqueda para obtener los datos.\n";
		internal const string Notificacion = "Notificación";
		internal const string SIN_DATOS = "No existen datos para mostrar";
		internal const string MODIFICACION_SUCCESS = "Se modificaron los datos correctamente";
		internal const string GUARDAR_SUCCESS = "Se guardaron los datos correctamente";
		internal const string GUARDAR_SUCCESS_IMPRIMIR = "Se guardaron los datos correctamente\n¿Quieres imprimir éste movimiento?";
		internal const string ERROR_ARCHIVAR = "Ocurrió un error al archivar la compra";
		internal const string VALIDAR_CAMPOS = "Existen campos vacíos, por favor ingresa la información que se solicita.";
		internal const string ERROR_SUELDO = "Antes de editar ésta información, primero debes ingresar el sueldo total o ingresar un valor correcto.";
		internal const string NOTIFICACION_BORRAR_GRILLA = "Se ha encontrado datos registrados en la tabla que quieres actualizar\n¿Deseas eliminar los datos y crear nuevos?";
		internal const string VALIDAR_FORMULARIO = "Existen campos vacíos, por favor ingresa la información que se solicita";
		internal const string ERROR_TIPO_CONTRATO = "Debes escoger un tipo de Contrato o tener un sueldo mayor o igual al sueldo mínimo.";
		internal const string ERROR_TEXT = "Éste campo es obligatorio";
		internal const string SIN_DATOS_GRILLAS = "No existen datos en la fecha solicitada.";
		internal const string ERROR_EXISTENCIA = "Ya se encuentra creado un registro con la fecha que acabas de ingresar.\nPor favor intenta con otra fecha.";
		internal const string DATO_ERRONEO = "Por favor corrige ésta información.";
		internal const string ERROR_GUARDAR = "Ocurrió un error al guardar los datos.\n";
		internal const string ERROR_EXISTENCIA_DESCUENTO = "Ya se encuentra creado un registro con la fecha que acabas de ingresar.\n¿Quieres cargar los valores para modificarlos?";

		internal const string SIN_DATOS_GRILLA = "No existen datos para guardar, intenta nuevamente con datos ingresados";
		internal const string CAMPO_OBLIGATORIO = "Éste campo es obligatorio";
		internal const string SIN_DATOS_INGRESOS_DESCUENTOS = "Áún no se han registrado datos en la fecha solitada.";
		internal const string EXISTENCIA_CEDULA = "La persona que quieres agregar ya se encuentra registrada.\nPor favor intenta con otra identificación";
		internal const string EXISTENCIA_MARCA = "La marca que quieres agregar ya se encuentra registrada.\nPor favor intenta con otra diferente";
		internal const string EXISTENCIA_TIPO_COMPUTO = "El tipo que quieres agregar ya se encuentra registrada.\nPor favor intenta con otra diferente";
		internal const string EXISTENCIA_FARMACIA = "Ya se encuentra registrada una farmacia con el mismo número.";

		internal const string CERRAR_FORM = "¿Estás seguro de cerrar la aplicación?";
		internal const string CERRAR_FORMULARIO = "Hemos notado que haz ingresado información en éste formulario.\nAl cerrarlo se borraran los datos que hayas ingresado\n¿Estás seguro de cerrar?";
		internal const string SELECCION_USUARIO = "Debes seleccionar un usuario para poder otorgar o quitar permisos.";
		internal const string SELECCION_PERFIL = "Debes seleccionar un perfil para poder otorgar o quitar permisos.";

		internal const string ARCHIVO_ABIERTO = "El archivo que intentas guardar está en ejecución, por favor cierra el archivo e intentalo nuevamente";

		internal const string SELECCIONAR_VACACIONES = "Debes seleccionar un empleado para poder ejecutar ésta operación";
		internal const string SIN_INFORMACION_VACACIONES = "No existen días seleccionados para ejecutar ésta operación";

		internal const string BUSCA_GUARDAR = "Busca la carpeta para guardar el archivo";
		internal const string ERROR_ARCHIVO_EJECUCION = "El archivo que intentas guardar está en ejecución, por favor cierra el archivo e intentalo nuevamente";

		internal const string EXISTE_INFORMACION = "Hemos notado que haz ingresado información en éste formulario.\n¿Estás seguro de querer salir?";

		internal const string ELIMINAR_REGISTRO_GRILLA = "¿Estás seguro de eliminar éste registro?";

		internal const string PREGUNTAR_GUARDAR = "¿Estás seguro de guardar éste registro?";
		internal const string PREGUNTAR_MODIFICAR = "¿Estás seguro de modificar éste registro?";
		internal const string PREGUNTAR_ELIMINAR = "¿Estás seguro de eliminar éste registro?";
		internal const string PREGUNTAR_ACTIVAR = "¿Estás seguro de áctivar éste registro?";

		internal const string ERROR_ELIMINAR_EMPLEADO = "No se puede eliminar a ésta persona porque tiene un contrato áctivo.";
		internal const string EXITO_ELIMINAR = "Se eliminó correctamente el registro.";
		internal const string ERROR_ELIMINAR = "Ocurrió un error al eliminar el registro.";

		internal const string EXITO_ACTIVAR = "Se activó correctamente el registro.";
		internal const string ERROR_ACTIVAR = "Ocurrió un error al áctivar el registro.";

		internal const string ERROR_COPIAR = "No existen datos para copiar.";
		internal const string EXITO_COPIAR = "Los datos se copiaron correctamente.";
		internal const string SIN_FILAS_GRID = "Debes ingresar al menos un producto.";
		internal const string ERROR_EXISTE_PRODUCTO = "El artículo ya se encuentra agregado.";
	}
}
