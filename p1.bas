10 SCREEN 0, 0: WIDTH 80: COLOR 2, 0: PI = 3.14158
20 LOCATE 1, 20: PRINT "pie chart"
30 LOCATE 10, 15: INPUT "enter # of pie slices or Q to quit ", A$
40 IF "q" = A$ OR "Q" = A$ THEN END ELSE NU% = VAL(A$)
50 IF NU% = 0 THEN END
60 DIM DA(NU%): DIM RA(NU%): DIM CU(NU%)
70 GOSUB 400
80 TOT = 0
90 `
400 'Entering data
