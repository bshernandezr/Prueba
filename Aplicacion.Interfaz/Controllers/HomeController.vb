
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private db As New ModeloConnection
    'Agregamos el metodo Get para obtener la lista
    <HttpGet>
    Function Index() As ActionResult
        Return View(db.tienda.ToList())
    End Function
    'Agregamos el metodo Post para filtrar la lista teniendo como argumento el filtro
    <HttpPost>
    Function Index(filtro As String) As ActionResult
        Dim Tabla = db.tienda
        Dim Lista = db.tienda.ToList()
        For Each item In Lista
            Dim borrar = db.tienda.FirstOrDefault(Function(x) x.NombreEmpleado = item.NombreEmpleado)
            Tabla.Remove(borrar)
        Next
        Dim ListaFiltrada = db.empleado.GroupBy(Function(x) x.Cargo = filtro).ToList()
        For Each fila In ListaFiltrada
            For Each empleado In fila
                Dim dato = db.tienda.FirstOrDefault(Function(x) x.NombreEmpleado = empleado.NombreEmpleado)
                Tabla.Add(dato)
            Next
        Next
        Return View(Tabla.ToList())
    End Function


End Class
