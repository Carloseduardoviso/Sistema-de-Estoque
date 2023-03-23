function buscaFuncionario(){
    var retorno="";
    var pesq  = $("#pesq").val();
    $.ajax({
        url: base_url + "funcionario/buscaFuncionario_json" ,
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
			retorno += "<td align='center'> <a href='" + base_url + "funcionario/editar/" + data[key].id_cliente + "' class='btn alterar'>ALTERAR</a>";
			retorno += "<align='center'> <a href='" + base_url + "funcionario/excluir/" + data[key].id_cliente + "'  class='btn excluir'>excluir</a></td>";
			retorno += "</tr>";
            });

            
            $("#listaAluno").html(retorno);
        }
    });
}

function confirmar_exclusao(funcionario){
    if(!confirm("Tem certeza que deseja excluir o funcionario: " + funcionario + " ?")){
        return false;
    }
    return true;
}
