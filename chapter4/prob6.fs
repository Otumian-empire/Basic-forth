\ Write the definition for a word called WITHIN which expects three arguments:
\ ( n low-limit hi-limit -- ) 
\ and leaves a "true" flag only if "n" is within the range low -l imit < n < hi-limit

: WITHIN ( n low-limit hi-limit -- )
    rot swap over swap < swap rot > and ;