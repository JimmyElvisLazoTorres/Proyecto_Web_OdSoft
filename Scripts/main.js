const canvas = document.getElementById("canvas");
canvas.width = window.innerWidth - 60;
canvas.height = 500;

var context = canvas.getContext("2d");
context.fillStyle= "white";
context.fillRect(0,0, canvas.width, canvas.height);

var draw_color="black";
var draw_width="2";
var is_drawing = false;
var img = new Image();
img.src = "~/Content/imagenes/odontograma.png";


canvas.addEventListener("touchstart",start,false);
canvas.addEventListener("touchmove",draw,false);
canvas.addEventListener("mousedown", start, false);
canvas.addEventListener("mousemove", draw, false);

canvas.addEventListener("touchend", stop, false);
canvas.addEventListener("mouseup", stop, false);
canvas.addEventListener("mouseout", stop, false);

context.drawImage(img, 0, 0);

function start(event){
    is_drawing=true;
    context.beginPath();
    context.moveTo(event.clientX-canvas.offsetLeft,event.clientY-canvas.offsetTop);
    event.preventDefault();
    context.drawImage(img, 0, 0);
}

function draw(event){
    if (is_drawing){
        context.lineTo(event.clientX-canvas.offsetLeft,
                        event.clientY-canvas.offsetTop);
        context.strokeStyle=draw_color;
        context.lineWidth=draw_width;
        context.lineCap="round";
        context.lineJoin="round";
        context.stroke();
        context.drawImage(img,0, 0);
    }
    event.preventDefault();
}

function stop(event) {
    if (is_drawing) {
        context.stroke();
        context.closePath();
        is_drawing = false;
        context.drawImage(img, 0, 0);
    }
    event.preventDefault();
}



