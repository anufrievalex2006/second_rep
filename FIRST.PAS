program first;
uses crt;
var a, b, j: integer;
var a1, a2: real;

begin
     clrscr;
     readln(a, b);
     a1 := (sin(a) * sin(a)) + (cos(b) * cos(b));
     for j := a to b do
     a2 := a2 + (a + b);
     writeln(a1, '; ', a2);
     a1 := a mod b;
     a2 := trunc(a2 + b) mod trunc(a);
     writeln(a2);
end.
