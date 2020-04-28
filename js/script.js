$('#espera').hide();
$('#terminado').hide();
let numero="0";
var json={};
var persona=[];

//json.Nombre='Mario';
//json.Apellidos='Tovar';
//json.Edad=23;
//json.Email='prueba@sfdsf.sd';
//persona.push(json);
//console.log(json);
//console.log(json.Nombre);

//json.Nombre='Angel';
//json.Apellidos='Lopez';
//json.Edad=20;
//json.Email='prueba@sfdsf.sd';

console.log(persona);
console.log(JSON.stringify(persona));

$(function() {

 document.querySelector('#btn_guardar').addEventListener('click',guardar);
 
});

function guardar() {

 json.Nombre=document.getElementById('txtnombre').value;
 json.Apellidos=document.getElementById('txtapellidos').value;
 json.Edad=document.getElementById('txtedad').value;

 var datos="{'propiedad':"+JSON.stringify(json)+"}";
 console.log(datos)

 $.ajax({
  contentType: 'application/json'
  ,method: 'POST'
  ,dataType: 'json'
  ,data: datos
  ,url: 'swpersona.asmx/Guardarsw'
  ,beforeSend: function() { $('#espera').show(); }
   ,success: exito
  ,complete: function() { $('#espera').hide(); }
   ,error: function(r) { console.log(r); }
  });

}


function exito(datos) {
 //alert('Se guardo correctamente');

 if(datos.d === true)
  $('#terminado').show();
 else
  console.log(datos);
 
 

}