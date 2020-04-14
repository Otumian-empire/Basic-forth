( You're the inventory programmer at Maria's Egg Ranch.
Define a word called EGG.CARTONS which expects on the stack
the total number of eggs laid by the chickens today and
prints out the number of cartons that can be filled with a
dozen each, as well as the number of left-over eggs. )

: EGG.CARTONS ( numberOfEggs -- remainderOfEgss numberOfCartons  )
12 /MOD SWAP ." There is (are) " . ." carton(s) of egg(s) and " . ." other egg(s)." ;

