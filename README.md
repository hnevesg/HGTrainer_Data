# HGTrainer_Data
Repositorio que contiene los archivos generados a partir de la ejecución del juego de Realidad Virtual **HGTrainer**. Los datos se almacenan en formatos CSV y TXT, y cubren diferentes aspectos del rendimiento y fiabilidad del sistema.

### Performance
 Carpeta que incluye los archivos relativos a la ejecución de **OVRMetrics** y **VRApi**. Este últimp se genera por defecto al utilizar el Plugin y SDK de Oculus (Meta). Se puede ver que los valores de ambos archivos coinciden o son muy parecidos en todos los parámetros que miden.
 
 [!NOTE] 
 En el archivo TXT, se puede encontrar la información relevante comenzando desde la línea que contiene `UNITY GAME STARTS`.

### Fiability
 Carpeta con los archivos `.csv`. correspondientes al seguimiento del **tracking** durante las sesiones. Estos archivos han sido utilizados para el análisis de la fiabilidad del sistema de tracking.

 Además, contiene también el archivo `.csv` con el historial de todas las sesiones, que muestra el número de goles y paradas realizadas en cada una.