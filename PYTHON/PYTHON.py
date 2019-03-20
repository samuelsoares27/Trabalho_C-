#Importação das bibliotecas
import os
import cv2

#Fazendo a leitura da imagem 
original  = cv2.imread("cranio.png")

Gaussiano = original

#Embaçado baixa 1 vezes usando Gaussiano
Gaussiano = cv2.GaussianBlur(Gaussiano,(3,3),0)

#Subtraindo a imagem com filtro Gaussiano com a imagem Original
ResultanteImagem =  cv2.subtract(original,Gaussiano)
#ResultanteImagem =  cv2.subtract(Gaussiano,original)

#Soma da imagem original com a imagem com o filtro Gaussiano
Soma = cv2.add(original, ResultanteImagem)

#Escreve de volta no arquivo
cv2.imwrite('nova.png',Soma)
print("Imagem processada com sucesso no Python")
os.system("pause")