\ Define a word called CARD which, given a person's age on the stack, 
\ prints out either one of these two messages (depending on the relevant laws in your area):
\ ALCOHOLIC BEVERAGES PERMITTED or UNDER AGE

: CARD ( age -- ) 
    18 >= if ." ALCOHOLIC BEVERAGES PERMITTED" else ." UNDER AGE" then cr ;