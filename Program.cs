Console.WriteLine("Enter numbers");

string? value = "";
int valueNumber = 0;
List<int> listValue = new List<int>();
do
{
    value = Console.ReadLine();
    if(value != null){
        valueNumber = Int32.Parse(value);
    }
    if (valueNumber != 0)
    {
        listValue.Add(valueNumber);
    }
} while (value != "0" && value != null);

foreach (var v in listValue)
{
        double sum = 0;
        double val = v;
    do{
        double numberOfDigits = Math.Floor(Math.Log10(val) + 1);
        for (int i = 1; i <= numberOfDigits; i++){
            if(i == 1){
                sum = val % 10;
            } else {
                double val1 = (val / Math.Pow(10, i - 1)) % 10;
                sum = sum + Math.Floor(val1);
            }
        }
        if(sum >= 10){
            val = sum;
        }
    }while(sum >= 10);
    Console.WriteLine(sum);
}
