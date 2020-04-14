\ Write the definition of GUESS, that program will either respond "TOO HIGH," "TOO LOW," 
\ or "CORRECT!" , making sure that the answer-number will stay on the stack through 
\ repeated guessing until the correct answer is guessed,after which the stack should be clear.

: PROCEDURE ( n m -- )
    over swap dup rot swap ;

: GUESS ( n m -- )
    PROCEDURE
    < if ." TOO HIGH"
        drop
    else 
        PROCEDURE
        > if ." TOO LOW"
            drop
        else ." CORRECT"
        2drop
        then
    then ;

7 page \ the screte number is 7