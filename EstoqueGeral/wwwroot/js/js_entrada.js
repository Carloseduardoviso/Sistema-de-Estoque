$(function(){

    $("#pesq" ).autocomplete({
        source: function(request, response){
            $.ajax({
                url: base_url + "produto/buscaProduto_json" ,
                type: "post",
                dataType: 'json' ,
                data: {pesq: request.term},
                success: function (date){
                    response ($.map(data,function(item){
                        return{
                            label: item.produto, 
                            id: item.id_produto
                        }
                    }));
                        
                }
            });
        },
        select:function(event, ui){
            if(ui.item){
                $("#id_produto").val(ui.item.id);
                $("#qtde").focus();
            }
        }
          
    });
}); 