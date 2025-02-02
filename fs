<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Valentine's Day Question</title>
    <style>
        #yesButton {
            font-size: 20px;
            padding: 10px 20px;
            margin: 10px;
            cursor: pointer;
        }
        #noButton {
            font-size: 20px;
            padding: 10px 20px;
            margin: 10px;
            cursor: pointer;
        }
        #dancingSticker {
            display: none;
            margin-top: 20px;
            width: 200px;
        }
    </style>
</head>
<body>
    <h1>Will you be my Valentine, AJ?</h1>
    <button id="yesButton">Yes</button>
    <button id="noButton">No</button>
    <img id="dancingSticker" src="https://media.giphy.com/media/13VVV4Z72kzD6s/giphy.gif" alt="Dancing Sticker">

    <script>
        let yesButton = document.getElementById('yesButton');
        let noButton = document.getElementById('noButton');
        let dancingSticker = document.getElementById('dancingSticker');
        let noClicks = 0;

        noButton.addEventListener('click', function() {
            noClicks++;
            if (noClicks > 0) {
                yesButton.style.fontSize = (20 + noClicks * 5) + 'px'; // Increase font size of the "Yes" button
            }
        });

        yesButton.addEventListener('click', function() {
            alert('Yay! You said yes!');
            dancingSticker.style.display = 'block';  // Show dancing sticker
        });
    </script>
</body>
</html>
