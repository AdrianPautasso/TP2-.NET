$(document).ready(function () {
    $("#bodyForm").validate({
        rules: {
            <%=txtMateria.UniqueID %>: { required: true },
            <%=txtHsSem.UniqueID %>: { required: true, number: true },
            <%=txtHsTot.UniqueID %>: { required: true, number: true }
        },
        messages: {
            <%=txtMateria.UniqueID %>: { required: " Este campo es obligatorio", },
            <%=txtHsSem.UniqueID %>: { required: " Este campo es obligatorio", number: "Debe ser un número" },
            <%=txtHsTot.UniqueID %>: { required: " Este campo es obligatorio", number: "Debe ser un número" }
        },
    });
})
