"""funkcja jest nieoptymalna. Można ją skrócić redukując dolną pętle do postaci w jakiej jest górna,
jednak sam pomysł na to jest całkiem do wyjebania, chociaż skróci zapis, nie poprawi w żaden sposób wydajności ,
a czytelność nawet pogorszy.
skomplikowane indeksowanie wymaga wprowadzenia dodatkowych funkcji generujących wspólczynniki które pozwalaj
 redukować pętle. Całość powinna zostać zrefaktoryzowana, na pewno rozdzielolna na 2 funkcje,"""

def factorOne(num):
    return [(-1) ** (num // 2), (-1) ** ((1 + num) // 2)]
def factorTwo(lettPos):
    return 1 if lettPos == 0 else -lettPos // 2
def factorThree(lettPos):
    return 1 if lettPos == 1 else -1 if lettPos == 3 else 0

def spiralize(word):
    maxArray=[0,0,0,0]
    actArr=[0,0]
    for lnum,letter in enumerate(word):
        letLen = ord(letter)-ord('a')
        lettPos = (lnum) % 4;

        actArr[lettPos % 2] += letLen * factorOne(lettPos)[0]
        actArr[1 - (lettPos % 2)] += 1 * factorOne(lettPos)[1]
        if lettPos in [0,1]:
            if abs(maxArray[lettPos])<abs(actArr[lettPos%2]):maxArray[lettPos]=actArr[lettPos%2]
        else:
            if maxArray[lettPos] > actArr[lettPos % 2]: maxArray[lettPos] = actArr[lettPos % 2]
    matrix = [[" "]*(maxArray[1]+abs(maxArray[3])+1) for _ in range((maxArray[0]+abs(maxArray[2])+1))]
    column, row = abs(maxArray[3]),abs(maxArray[2])
    actualPosition =  [abs(maxArray[2]),abs(maxArray[3])]
    for lnum,letter in enumerate(word):
        letLen = ord(letter)-ord('a')+1
        lettPos = (lnum) % 4;
        if lettPos==0:
            for i in range(letLen):
                matrix[actualPosition[0]+i*factorTwo(lettPos)][actualPosition[1]+i*factorThree(lettPos)] = letter
            actualPosition[0]+=letLen-1
            actualPosition[1]+=1

        elif lettPos == 2:
            for i in range(letLen):
                matrix[actualPosition[0]+i*factorTwo(lettPos)][actualPosition[1]+i*factorThree(lettPos)] = letter
            actualPosition[0]-=letLen-1
            actualPosition[1]-=1
        elif lettPos == 1:
            for i in range(letLen):
                matrix[actualPosition[0]][actualPosition[1]+i] = letter
            actualPosition[1]+=letLen-1
            actualPosition[0]-=1
        else:
            for i in range(letLen):
                matrix[actualPosition[0]][actualPosition[1]-i] = letter
            actualPosition[1]-=letLen-1
            actualPosition[0]+=1
    Buil = ""
    for mrow in matrix:
        for el in mrow:
            Buil+=el
        Buil+="\n"
    return Buil[:-1]