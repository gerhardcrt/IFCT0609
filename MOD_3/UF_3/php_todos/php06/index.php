<?php 
echo "<p style='font-size:32px;'>";
//PHP06 - Bucles y ARRAYS

$numeros = array(1,5,67,8,9);

echo $numeros[2]." ";

for ($i = 0; $i < count($numeros); $i++) {
    echo $numeros[$i];
}