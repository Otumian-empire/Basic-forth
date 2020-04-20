\ mist
\ Define a word called  that will compute exponenetial values, like this
\ 7 2  . 49 ok
\ 2 4  . 16 ok
    
: ** ( n a -- n^a )
    dup
    0= if
        2drop 1
    else
        dup
        1 < if
            2drop 0   
        else
            dup
            1 = if
                drop 
            else
                        ( n a )
                over swap  ( n n a )
                1- 0 do    ( n n )
                    over * ( n n*n)
                loop nip
            then
        then
    then ;
 
\ 10 0 ** . cr bye
\ 10 1 ** . cr bye
\ 10 2 ** . cr bye
\ 7 2 ** . cr bye
\ 2 4 ** . cr bye
