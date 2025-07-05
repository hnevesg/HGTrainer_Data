# HGTrainer_Data
Repositorio que contiene los archivos generados a partir de la ejecución del juego de Realidad Virtual **HGTrainer**. Los datos se almacenan en formatos CSV y TXT, y cubren diferentes aspectos del rendimiento y fiabilidad del sistema.

### Device Performance
 Carpeta que incluye los archivos relativos a la ejecución de **OVRMetrics** y **VRApi**. Este último se genera por defecto al utilizar el Plugin y SDK de Oculus (Meta). Se puede ver que los valores de ambos archivos coinciden o son muy parecidos en todos los parámetros que miden. Además, se encuentra también el vídeo correspondiente a la sesión.

 > [!NOTE] 
 > En el archivo TXT, se puede encontrar la información relevante comenzando desde la línea que contiene `UNITY GAME STARTS`.

### Tracking Fiability
 Carpeta con los archivos `.csv`. correspondientes al seguimiento del **tracking** durante las sesiones. Estos archivos han sido utilizados para el análisis de la fiabilidad del sistema de tracking.

 Además, contiene también el archivo `.csv` con el historial de todas las sesiones, que muestra el número de goles y paradas realizadas en cada una. Y los vídeos correspondientes, que permitieron validarlo no solo en el entorno virtual, sino en el real.

### Wireless data
El archivo HGTrainer_WirelessTimes.txt contiene los logs que muestran la duración del envío, el tamaño del *payload*, el tamaño de las cabeceras, y la eficiencia (de carga útil) y *overhead* ratio.

Además, se encuentra también el *script* utilizado para calcularlo. 


 > [!NOTE] 
 > En el archivo TXT, se puede encontrar la información relevante comenzando desde la línea que contiene `Tiempo total`.
