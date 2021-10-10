# Interfaces Inteligentes Práctica 1

## Guía
- Para la realización de la práctica me he guiado por los siguientes requerimientos:

  - Incluir objetos 3D básicos
  - Incluir algún objeto complejo de Standard Assets.
  - Incluir un objeto libre de la Asset Store que no sea de los Standard Assets.
  - Crear un terreno (opcional).
  - Cada objeto debe tener una etiqueta que lo identifique.
  - La escena debe tener 2 fuentes de luz.
  - Utilizar prefabs de standard assets para un FPS o Third Person
  - Agregar un script que escriba en la consola los objetos que se han utilizado, un identificador numérico que le asignes a cada uno de los objetos y el valor de un contador     que se actualiza en cada iteración para cada objeto.

## Resumen
- Antes de comenzar a realizar la práctica, he dedicado un tiempo a visualizar distintos vídeos tutoriales de iniciación en Unity y a leer algunas páginas web. Posteriormente,   he instalado y configurado la máquina para su realización. Una vez realizado lo anterior, he procedido a desrcargar paquetes en [Asset Store](https://assetstore.unity.com/),   de los cuales he adquirido los siguientes: [Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351), [Starter Assets](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-196526) y [Vehicle Parking Lot Garage Gate PBR](https://assetstore.unity.com/packages/3d/environments/roadways/vehicle-parking-lot-garage-gate-pbr-111423).
  
  A continuación, lo primero que he hecho ha sido colocar un objeto 3D báscio como era el terreno, al cual le he aplicado una textura y he realizado unas montañas. Posteriormente, he colocado unos objetos de la [Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351), en este caso una palmera y un coche. Con respecto a los objetos libres, me he decantado por una casa y unas escaleras que se encontraban en [Starter Assets](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-196526). Con la finalidad de hacer una casa con un garaje, he hecho uso de 4 objetos básicos 3D(Cilindro), los cuales tienen la funcionalidad de representar a unos pipotes de piedra. Seguidamente, he aplicado 2 tipos de luz, una luz direccional con el fin de iluminar toda la escena y una luz spot con el fin de iluminar el interior de la casa. Una vez realizado todo lo anterior, he procedido a colocar la barrera del parking([Vehicle Parking Lot Garage Gate PBR](https://assetstore.unity.com/packages/3d/environments/roadways/vehicle-parking-lot-garage-gate-pbr-111423)), con el objetivo de colocar un objeto con movimiento y un prefabs FPS situado en la [Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351). Finalmente, he realizado las distintas tags, las cuales he hecho una para cada objeto que aparece en la escena, así como su script correspondiente para mostrar la información por la consola.
  
 ## GIF del funcionamiento
 ![GIF](https://github.com/EduardoEB3/InterfacesInteligentes_P1/blob/main/GIF/Funcionamiento.gif)
 
 ## Estructura de directorios
 El directorio está organizado de la siguiente manera:
  
      .
      ├── GIF
          ├── Funcionamiento.gif
      ├── scripts
          ├── ScriptCamara.cs
          ├── ScriptCasa.cs
          ├── ScriptCoche.cs
          ├── ScriptEscalera.cs
          ├── ScriptFPS.cs
          ├── ScriptLuzDirec.cs
          ├── ScriptLuzSpot.cs
          ├── ScriptPalmera.cs
          ├── ScriptParking.cs
          ├── ScriptPipote1.cs
          ├── ScriptPipote2.cs
          ├── ScriptPipote3.cs
          ├── ScriptPipote4.cs
          ├── ScriptPipote5.cs
          ├── ScriptTerreno.cs
          

**Realizado por:** *Eduardo Expósito Barrera*

**Correo institucional:** alu0101230382@ull.edu.es
