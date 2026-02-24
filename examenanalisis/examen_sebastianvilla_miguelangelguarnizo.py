
#EXAMEN REALIZADO POR : MIGUEL ANGEL GUARNIZO SALAZAR Y JUAN SEBASTIAN VILLA RODAS

def solucion_resta_minima(arr):
    n = len(arr)
    min_resta = arr[0]


    for i in range(n):
        for j in range(i,n):
            resta = 0
            for k in range(i, j + 1):
                resta += arr[k]
            min_resta = min(min_resta, resta)
            
    return min_resta
            



arr = [ 8, 2, 15, 4, 20,1]   
arr2 = [10,20,30,40]

print(f"La resta minima es : {solucion_resta_minima(arr)}")
print(f"La resta minima es : {solucion_resta_minima(arr2)}")

# Primero observamos que la entrada n, y a la hora de hacer los recorridos pudimos observar
# que hay que implementar tres ciclos anidados los cuales dependen de la entrada (n), lo cual
# hace que la complejidad del algortimo sea O(n³), porque probamos todos los subarreglos posibles
# para cada par de indices. Por lo que al usar los tres ciclos nuestra complejidad seria : n x n x n = O(n³)


# La forma en la que se podría optimizar este algoritmo implementando un solo recorrido en el cual
# vamos a ir guardando en nuestra variable "resta" todos los resultados y luego comparando con una
# variable "min" para que asi en esta se vaya guardando el valor mínimo. En este caso la complejidad
# se volveria lineal (O(n)).