# Criando um Sistema e Abstraindo um Celular com POO em C#
Construção de um sistema em .NET, do tipo Console, que trabalha com smartphones a partir de conhecimentos de Programação Orientada a Objetos.  

A modelagem utilizada permite que diferentes marcas e modelos de celulares tenham seus comportamentos particulares e um maior reuso do código.

## O projeto
![Diagrama das classes do projeto](Imagens/diagrama.png)

A partir da abstração de um celular, consolidada na classe **Smartphone**, têm-se as classes **Nokia** e **iPhone**, para dois diferentes tipos de celulares. 

O método **InstalarAplicativo** é sobrescrito em cada uma das classes filhas, pois cada modelo de celular possui diferentes maneiras de instalar um aplicativo.  
<br>
*(Desafio de projeto do bootcamp "Pottencial .NET Developer" oferecido pela [DIO](https://www.dio.me/) e pela [Pottencial](https://pottencial.com.br/))*
