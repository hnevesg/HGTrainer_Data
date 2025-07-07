# HGTrainer_Data
Repositorio que contiene los archivos generados a partir de la ejecución del juego de Realidad Virtual **HGTrainer**. Los datos se almacenan en formatos CSV y TXT, y cubren diferentes aspectos del rendimiento y fiabilidad del sistema.

### Device Performance
 Carpeta que incluye los archivos relativos a la ejecución de **OVRMetrics** y **VRApi**. Este último se genera por defecto al utilizar el Plugin y SDK de Oculus (Meta). Se puede ver que los valores de ambos archivos coinciden o son muy parecidos en todos los parámetros que miden. Además, se encuentra también el vídeo correspondiente a la sesión.

 > [!NOTE] 
 > En el archivo TXT, se puede encontrar la información relevante comenzando desde la línea que contiene `UNITY GAME STARTS`.

### Tracking Fiability
 Carpeta con los archivos `.csv`. correspondientes al seguimiento del **tracking** durante las sesiones. Estos archivos han sido utilizados para el análisis de la fiabilidad del sistema de tracking.

 Además, contiene también el archivo `.csv` con el historial de todas las sesiones, que muestra el número de goles y paradas realizadas en cada una. Y los enlaces a los vídeos que permitieron validarlo no solo en el entorno virtual, sino en el real.

### 3D Model Precission
El archivo HGTrainer-ModelPrecission.txt contiene los logs que muestran la distancia tanto del HMD al suelo, como la de la cabeza del modelo al suelo; y la distancia al controlador, y del hombro del modelo a la mano.

Además, se encuentran también los *scripts* utilizados para calcularla. 

 > [!NOTE] 
 > En el archivo TXT, se puede encontrar la información relevante comenzando desde la línea que contiene `HMD Height` y la línea que contiene `Virtual Hand Distance`.


### Wireless data
El archivo HGTrainer-WirelessTimes.txt contiene los logs que muestran la duración del envío, el tamaño del *payload*, el tamaño de las cabeceras, y la eficiencia (de carga útil) y *overhead* ratio. (En cada sesión se envían 2 archivos, el Historial, que aumenta tras cada sesión, y el `.csv` con los datos de *tracking* de la sesión.)

Además, se encuentra también el fragmento del *script* `CSVUploader.cs` utilizado para calcularlo. 

 > [!NOTE] 
 > En el archivo TXT, se puede encontrar la información relevante comenzando desde la línea que contiene `Tiempo total`.
