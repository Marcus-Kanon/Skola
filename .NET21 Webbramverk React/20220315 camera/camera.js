let canvas = document.querySelector('#canvas');
let context = canvas.getContext('2d');
let video = document.querySelector('#video');

class VideoProcessor {
    static set stream(value) {
        VideoProcessor.s = value;
    }

    static get stream() {
        return VideoProcessor.s;
    }

    constructor() {

    }

    static bindStream(data) {
        if(data.srcObject == null) {
            console.log("Stream not loaded");
        }

        VideoProcessor.stream = data;
    }
}

if(navigator.mediaDevices && navigator.mediaDevices.getUserMedia)
{
    navigator.mediaDevices.getUserMedia({video: true}).then(stream => {
        VideoProcessor.bindStream(stream);
        video.srcObject = VideoProcessor.stream;
        video.play();
    });
}

function greyFrame() {
    context.drawImage(video, 0, 0, 640, 480);
    var frame = context.getImageData(0, 0, 640, 480);
    var l = frame.data.length / 4;

    for (var i = 0; i < l; i++) {
      var grey = (frame.data[i * 4 + 0] + frame.data[i * 4 + 1] + frame.data[i * 4 + 2]) / 3;

      frame.data[i * 4 + 0] = grey;
      frame.data[i * 4 + 1] = grey;
      frame.data[i * 4 + 2] = grey;
    }
    context.putImageData(frame, 0, 0);

    return;
  }

document.getElementById('snap').addEventListener('click', () => {
    context.drawImage(video, 0,0, 640,480);
})