( After entering
the words in Prob. 1, enter a new definition
for GIVER to print someone else's name, then execute THANKS
again.
Can you explain why THANKS still prints out the first
giver's name? )


: GIFT ( -- ) ." gforth manual " ;

: GIVER ( -- ) ." Dan " ;

: THANKS ( -- ) CR ." Dear " GIVER ." , " CR 4 SPACES
 ." Thanks for the " GIFT ;
 
THANKS

: GIVER ( -- ) ." Ayisha " ;

THANKS
