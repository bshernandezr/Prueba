@ModelType  IEnumerable(Of tienda)
@*Definimos el modelo de la vista t creamos una variable string que se enviara al metodo post y hacer el filtro*@
@code
    Dim a = " "
End Code

<h2>Registro de empleados</h2>

<form action="@Url.Action("Index", "Home", New With {.filtro = a})" method="post">     
    <div class="form-group">
        <label>Filtrar por cargo</label> <br /> 
        @Html.TextBox(a)        
        <input class="btn btn-success" type="submit" value="Filtrar" />
    </div>
        
</form>

<hr />

<table class="table table-bordered">
    <tr>
        <th>Dia trabajado</th>
        <th>Tienda</th>
        <th>Empleado</th>
    </tr>
    @*Recorremos la tabla e imprimimos los empleados segun las especificaciones*@
    @For Each registro In Model
    @<tr>
        <td>@registro.FechaTrabajo</td>
        <td>@registro.NombreTienda</td>
        <td>@registro.NombreEmpleado</td>
    </tr>
    Next
</table>
