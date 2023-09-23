//practica de clase 

//funcion Now obtiene la fecha actual 
//DateTime dtToday = DateTime.Now;
//Console.WriteLine(dtToday);

//formato largo
//string formatteDateTime = dtToday.ToString("F");
//Console.WriteLine(formatteDateTime);
//Console.WriteLine();

//formato corto
//String formatteDateTime1 = dtToday.ToString("g");
//Console.WriteLine(formatteDateTime1);
//Console.WriteLine();
//formato largo
//String formatteDateTime2 = dtToday.ToString("G");
//Console.WriteLine(formatteDateTime2);
//Console.WriteLine();

//String formatteDateTime3 = dtToday.ToString("f");
//Console.WriteLine(formatteDateTime3);
//Console.WriteLine();

//Miscelaneos
DateTime FH = DateTime.Now;

//String formato1 = FH.ToString("dddd',' dd MMMM yyyy HH:mm:ss");
//Console.WriteLine(formato1);

//String formato2 = FH.ToString("yyyy'-' MM'-'dd THH:mm:ss");
//Console.WriteLine(formato2);

//String formato3 = FH.ToString("yyyy'-' MM'-'dd THH:mm:ss.fffffffK");
//Console.WriteLine(formato3);

//String formato4 = FH.ToString("ddd',' dd MMM yyy HH:mm:ss 'GTM'");
//Console.WriteLine(formato4);

//meses
//DateTime examplesmonths;
//examplesmonths = FH.AddMonths(3);
//Console.WriteLine(examplesmonths);

//years
//Console.WriteLine(examplesmonths.AddYears(4));

////dias
//Console.WriteLine(examplesmonths.AddDays(2.5));

//horas
//Console.WriteLine(examplesmonths.AddHours(5));

////minutos
//Console.WriteLine(examplesmonths.AddMinutes(5));

//segundos
//Console.WriteLine(examplesmonths.AddSeconds(120));

Console.WriteLine(FH.DayOfWeek);


Console.WriteLine(FH.DayOfYear);

int a = 10;
long b = a;
Console.WriteLine(b.GetType());

float c = 3.14f;
double d = c;
Console.WriteLine(d.GetType());

char e = 'A';
int f= e;
Console.WriteLine(f.GetType());

double valor = 3.1416;
int valoint = (int)valor;
Console.WriteLine(valoint);

int num1 = 10;
double num2 = 5.5;
double resultado = num1 * (double)num2;
Console.WriteLine(resultado);


