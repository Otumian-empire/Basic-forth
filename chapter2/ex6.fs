\ write a definition for 9a^2 - ba (a b -- result)

: ex2fs6 ( a b -- result ) swap dup rot swap 9 * swap - * ;
: ex2fs6i ( a b -- result ) over 9 * swap - * ;
: 2c6 over 9 * swap - * ;
cr 2 3 ex2fs6 . cr 2 3 ex2fs6 . cr 2 3 2c6 . cr 

