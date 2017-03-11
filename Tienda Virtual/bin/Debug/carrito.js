$(document).ready(function(){
	carro=function(){
		$.ajax({
			url:$('#base_url').val() + 'productos/carrito.html',
			type:'post',
			data:{
				id:$('.badge').attr('id')
			},
			success:function(data){
				$('.badge').text(data);
			}
		});
	};
	carro();
	$('.add_carrito').on('click',function(){
		$('#producto-save').text('Agregar al carrito');
		context=$(this);
		$.ajax({
			type:'post',
			url:$('#base_url').val() + 'productos/mostrar.html',
			data:{
				id:context.attr('id')
			},
			success:function(data){
				datos=JSON.parse(data);
				$('.modal-title').text(datos.nombre);
				$('#id_modal').text(datos.id);
				$('#cat_modal').text(datos.cat);
				$('#precio_modal').text(datos.precio);
				$('#desc_modal').text(datos.desc);
				$('#cant_modal').text(datos.cantidad);
			}
		});
		$('#producto').modal('show');
	});
	$('#producto').on('hide.bs.modal',function(){
		$('.modal-title').text('Productos');
		$('#id_modal').text('');
		$('#cat_modal').text('');
		$('#precio_modal').text('');
		$('#desc_modal').text('');
		$('#cant_modal').text('');
	});
	$('#producto-save').on('click',function(){
		var cantidad = prompt('Cantidad');
		if(cantidad > parseInt($('#cant_modal').text()) || cantidad <= 0 ){
			alert('La cantidad no es válida');
			return false;
		}
		$.ajax({
			type:'post',
			url:$('#base_url').val() + 'productos/add_carrito.html',
			data:{
				producto:$('#id_modal').text(),
				usuario:$('.badge').attr('id'),
				cantidad:cantidad
			},
			success:function(data){
				carro();
				$('#producto').modal('hide');
				location.reload();
			}
		});
	});
});