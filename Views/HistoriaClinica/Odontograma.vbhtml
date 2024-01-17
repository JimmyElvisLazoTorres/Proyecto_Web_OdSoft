
@Code
    Layout = Nothing
End Code
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="UTF-8" />

        <link href="~/styles.css" type="text/css" rel="stylesheet" />
       
    </head>
    <body>
        <div class="field">
            <canvas id="canvas"> </canvas>
            <div class="tools">
                <button type="button" class="button">Undo</button>
                <button type="button" class="button">Clear</button>
                <div class="color-field" style="background-color: red;"></div>
                <div class="color-field" style="background-color: blue;"></div>
                <div class="color-field" style="background-color: green ;"></div>
                <div class="color-field" style="background-color: yellow;"></div>
                <input type="color" class="color-picker">
                <input type="range" min="1" max="100" class="pen-range">
            </div>
        </div>
        <img src="~/Content/imagenes/odontograma.png"/>
        <script src="~/Scripts/main.js"></script>
    </body>
  

    </html>