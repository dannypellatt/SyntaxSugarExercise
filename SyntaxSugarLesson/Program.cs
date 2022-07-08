// inferred typing

var answer = 4;
string response;
if (answer < 9)
{
    response = answer + " is less than nine";
}
else
{
     response = answer + " is greater than or equal to nine";
}


// string interpolation

int answer2 = 4;
string response2;
if (answer < 9)
{
    response2 = ($"{answer2} is less than nine");
}
else
{
    response2 = ($"{ answer} is greater than or equal to nine");
}



// ternary operators

int answer3 = 4;
string response3 = (answer3 < 9) ? $"{answer3} is less than nine" : $"{answer3} is greater than or equal to nine";