<?php 
echo "<p style='font-size:32px;'>";
$nombre = 'Ramón';
$edad = 43;

$numeros = array(1,5,67,8,9);

echo $numeros[2]." <br/>";

for ($i = 0; $i < count($numeros); $i++) {
    echo $numeros[$i]."<br/>";
}

$numeros = array('suspenso','aprobado','notable','sobresaliente','matrícula de honor');

for ($i = 0; $i < count($numeros); $i++) {
    echo $numeros[$i]."<br/>";
}

echo "<br/>----------------------<br/>";

$i=0;
while($i<count($numeros)){
	echo $numeros[$i]."<br/>";
	$i++;
}

echo "<br/>----------------------<br/>";

$i=0;
while($i<count($numeros)):
	echo $numeros[$i]."<br/>";
	$i++;
endwhile;