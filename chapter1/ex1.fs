( Define a word called GIFT which, when executed, will type
out the name of some gift. For example, you might try:
Now define a word called GIVER which will print out a person's first name.
Finally, define a word called THANKS which includes the new FORTH words 
GIFT and GIVER, and prints out a message something like this:
  
DEAR STEPHANIE,
    THANKS FOR THE BOOKENDS. ok )
.( this is the first exercise in chapter 1 )

: GIFT ( -- ) ." gforth manual " ;

: GIVER ( -- ) ." Dan " ;

: THANKS ( -- ) CR ." Dear " GIVER ." , " CR 4 SPACES
 ." Thanks for the " GIFT ;
 
THANKS

