// Arithmetics Operations Notes from Pedro Romanazzi Course

// OPERACIONES ARITMETICAS BASICAS
int NUM1, NUM2, RESUL;
string linea;
Console.Write( "PRIMER NÚMERO :" );
linea = Console.ReadLine();
NUM1 = int .Parse(linea);
Console.Write( "SEGUNDO NÚMERO :" );
linea = Console.ReadLine();
NUM2 = int .Parse(linea);
Console.WriteLine();
RESUL = NUM1 + NUM2;
Console.WriteLine( "LA SUMA ES {0}: " , RESUL);
RESUL = NUM1 - NUM2;
Console.WriteLine( "LA RESTA ES: {0} - {1} = {2} " , NUM1, NUM2, RESUL);
RESUL = NUM1 * NUM2;
Console.WriteLine( "LA MULTIPLICACIÓN ES: " + RESUL);
RESUL = NUM1 / NUM2;
Console.WriteLine( "LA DIVISIÓN ES: " + RESUL);
RESUL = NUM1 % NUM2;
Console.WriteLine( "EL RESIDUO ES: " + RESUL);
Console.Write( "Pulse una Tecla:" );
Console.ReadKey();




// Calcula el total de la compra de cada ítem
byte CantBebida, CantHamburguesa, CantPapas;
double APagar;
string linea;
const double PrecioB = 0.8;
const double PrecioH = 2;
const double PrecioP = 1.2;
Console.Write( "CANTIDAD DE HAMBURGUESAS :" ); linea = Console.ReadLine();
CantHamburguesa = byte .Parse(linea);
Console.Write( "CANTIDAD DE PAPAS :" ); linea = Console.ReadLine();
CantPapas = byte .Parse(linea);
Console.Write( "CANTIDAD DE BEBIDAS :" ); linea = Console.ReadLine();
CantBebida = byte .Parse(linea);
Console.WriteLine();
APagar = (CantHamburguesa * PrecioH) + (CantPapas * PrecioP) + (CantBebida *
PrecioB);
Console.WriteLine( "VALOR A PAGAR: " + APagar);
Console.Write( "Pulse una Tecla:" );
Console.ReadKey();



// Se ingresan dos números y se muestra el mayor, el menor o si son iguales
int NUM1, NUM2;
string linea;
Console.Write( "NÚMERO 1 :" ); linea = Console.ReadLine();
NUM1 = int .Parse(linea);
Console.Write( "NÚMERO 2 :" ); linea = Console.ReadLine();
NUM2 = int .Parse(linea);
if ((NUM1 > NUM2))
{
Console.WriteLine( "{0} ES MAYOR QUE {1}" , NUM1, NUM2);
}
else
{
if ((NUM1 == NUM2))
{
Console.WriteLine( "{0} ES IGUAL A {1}" , NUM1, NUM2);
}
else
{
Console.WriteLine( "{0} ES MENOR QUE {1}" , NUM1, NUM2);
}
}
Console.WriteLine();
Console.WriteLine( "OTRA MANERA" );
string RESUL;
if (NUM1 > NUM2)
{
RESUL = "MAYOR" ;
}
else
if (NUM1 == NUM2)
{
RESUL = "IGUAL" ;
}
else
{
RESUL = "MENOR" ;
}
Console.WriteLine( "{0} ES {1} QUE {2}" , NUM1, RESUL, NUM2);
Console.Write( "Pulse una Tecla:" );
Console.ReadKey();





//Dado un importe, indica la cantidad de billetes de cada valor
//para llegar a ese importe
int CAN, C100, C50, C20, C10, C5;
C100 = 0;
C50 = 0;
C20 = 0;
C10 = 0;
C5 = 0;
string linea;
Console.Write( "DIGITE UNA CANTIDAD :" ); linea = Console.ReadLine();
CAN = int .Parse(linea);
if ((CAN >= 100))
{
C100 = (CAN / 100);
CAN = CAN - (C100 * 100);
}
if ((CAN >= 50))
{
C50 = (CAN / 50);
CAN = CAN - (C50 * 50);
}
if ((CAN >= 20))
{
C20 = (CAN / 20);
CAN = CAN - (C20 * 20);
}
if ((CAN >= 10))
{
C10 = (CAN / 10);
CAN = CAN - (C10 * 10);
}
if ((CAN >= 5))
{
C5 = (CAN / 5);
CAN = CAN - (C5 * 5);
}
Console.WriteLine( "BILLETES DE A 100: " + C100);
Console.WriteLine( "BILLETES DE A 50 : " + C50);
Console.WriteLine( "BILLETES DE A 20 : " + C20);
Console.WriteLine( "BILLETES DE A 10 : " + C10);
Console.WriteLine( "BILLETES DE A 5 : " + C5);
Console.WriteLine( "BILLETES DE A 1 : " + CAN);
Console.Write( "Pulse una Tecla:" );
Console.ReadKey();





//Según el tamaño de los datos, indica si el triángulo es
//equilátero, isósceles o escaleno
int LADO1, LADO2, LADO3;
string linea;
Console.Write( "DIGITE LADO 1 :" ); linea = Console.ReadLine();
LADO1 = int .Parse(linea);
Console.Write( "DIGITE LADO 2 :" ); linea = Console.ReadLine();
LADO2 = int .Parse(linea);
Console.Write( "DIGITE LADO 3 :" ); linea = Console.ReadLine();
LADO3 = int .Parse(linea);
if ((LADO1 == LADO2) & (LADO2 == LADO3))
{
Console.WriteLine( "TRIÁNGULO EQUILÁTERO. TODOS IGUALES" );
}
else
{
if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
{
Console.WriteLine( "TRIÁNGULO ESCALENO. NINGUNO IGUAL" );
}
else
{
Console.WriteLine( "TRIÁNGULO ISÓSCELES. DOS IGUALES" );
}
}
Console.Write( "Pulse una Tecla:" );
Console.ReadKey();





//Suma N números ingresados
byte CAN, K;
int NUM;
int SUM = 0;
string linea;
Console.Write( "LÍMITE:" ); linea = Console.ReadLine();
CAN = byte .Parse(linea);
for (K = 1; K <= CAN; K++)
{
Console.Write( "DIGITE UN NÚMERO:" ); linea = Console.ReadLine();
NUM = int .Parse(linea);
SUM += NUM;
}
Console.WriteLine( "SUMA TOTAL ES : " + SUM);
Console.WriteLine( "MEDIA ARITMÉTICA: " + SUM / CAN);
Console.Write( "Pulse una Tecla:" );
Console.ReadKey();




