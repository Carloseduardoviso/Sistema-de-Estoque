function buscaFornecedor(){
    var retorno="";
    var pesq  = $("#pesq").val();
    $.ajax({
        url: base_url + "fornecedor/buscaFornecedor_json" ,
        type: "post",
        dataType: 'json' ,
        data: {pesq: pesq},
        
        success: function (data){
            $.each(data, function(key){
            retorno += "<tr>";
			retorno += "<td align='left'>" + data[key].id_cliente + "</td>";
			retorno += "<td align='left'>" + data[key].cliente + "</td>";
			retorno += "<td align='left'>" + data[key].email + "</td>";
			retorno += "<td align='center'>" + data[key].celular + "</td>";
			retorno += "<td align='center'> <a href='" + base_url + "fornecedor/editar/" + data[key].id_cliente + "' class='btn alterar'>ALTERAR</a>";
			retorno += "<align='center'> <a href='" + base_url + "fornecedor/excluir/" + data[key].id_cliente + "'  class='btn excluir'>excluir</a></td>";
			retorno += "</tr>";
            });

            
            $("#listaAluno").html(retorno);
        }
    });
}

function confirmar_exclusao(fornecedor){
    if(!confirm("Tem certeza que deseja excluir o fornecedor: " + fornecedor + " ?")){
        return false;
    }
    return true;
}