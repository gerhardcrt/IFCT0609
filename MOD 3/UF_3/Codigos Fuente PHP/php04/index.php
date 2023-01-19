<?php 
$nombre = 'Ramón';
$edad = 43;

echo "<p style='font-size:32px;'>";
echo "Hola, te llamas: ".$nombre." y tienes ".($edad +1)." años";
$edad = 'cuarenta y cuatro';
echo " (".$edad.")";

echo "</p>";

/*
echo "<p style='font-size:32px;'>Hola ".$_POST['nombre']."</br>";
if ($_POST['edad']>=18)
{
	echo "Por tu edad te recomiendo este enlace: <a href='https://estrellagalicia.es/'>Estrella Galicia</a></p>";
}else
{
	echo "Por tu edad te recomiendo este enlace: <a href='https://www.disney.es/'>Disney</a></p>";
}
*/	
 