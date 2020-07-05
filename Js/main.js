var button = document.getElementsByClassName('login');
var modal = document.getElementById('page-modal');
var close = document.getElementsByClassName('delete')[0];

function fixarHead() {
  var posy = pageYOffset;
  var head = document.getElementById("head");
  	if(screen.width >= 1281 && screen.width <= 1500){
  		if(posy>=720){
  			head.style.visibility = "visible";
  		}
  		else{
  			head.style.visibility = "hidden";
  		}
	}
	else if(screen.width >=1750 && screen.width <=1920){
		if(posy>=701){
  			head.style.visibility = "visible";
  		}
  		else{
  			head.style.visibility = "hidden";
  		}
	}
	else if(screen.width <=1280){
		if(posy>=698){
  			head.style.visibility = "visible";
  		}
  		else{
  			head.style.visibility = "hidden";
  		}
	}
}
// function getTranslateY(myElement) {
//   var style = window.getComputedStyle(myElement);
//   var matrix = new WebKitCSSMatrix(style.webkitTransform);
//   return matrix.m42;
// }
// function getTranslateX(myElement) {
//   var style = window.getComputedStyle(myElement);
//   var matrix = new WebKitCSSMatrix(style.webkitTransform);
//   return matrix.m41;
// }

  button[0].onclick = function(){
    modal.style.display = 'block';
    modal.childNodes[3].style.position = 'fixed';
    modal.childNodes[3].style.top = 25+'%';
    if(window.innerWidth <= 1920 && window.innerWidth >= 1750){
      modal.childNodes[3].style.left = 34+'%';
    }
    else if(window.innerWidth >= 1281 && window.innerWidth <= 1500){
      modal.childNodes[3].style.left = 32+'%';
    }
    else if(window.innerWidth < 1281){
      modal.childNodes[3].style.left = 25+'%';
    }
  }
  button[1].onclick = function(){
    modal.style.display = 'block';
    modal.childNodes[3].style.position = 'fixed';
    modal.childNodes[3].style.top = 25+'%';
    if(window.innerWidth <= 1920 && window.innerWidth >= 1750){
      modal.childNodes[3].style.left = 34+'%';
    }
    else if(window.innerWidth >= 1281 && window.innerWidth <= 1500){
      modal.childNodes[3].style.left = 32+'%';
    }
    else if(window.innerWidth < 1281){
      modal.childNodes[3].style.left = 25+'%';
    }
  }
  button[2].onclick = function(){
    modal.style.display = 'block';
    modal.childNodes[3].style.position = 'fixed';
    modal.childNodes[3].style.top = 25+'%';
    if(window.innerWidth <= 1920 && window.innerWidth >= 1750){
      modal.childNodes[3].style.left = 34+'%';
    }
    else if(window.innerWidth >= 1281 && window.innerWidth <= 1500){
      modal.childNodes[3].style.left = 32+'%';
    }
    else if(window.innerWidth < 1281){
      modal.childNodes[3].style.left = 25+'%';
    }
  }
  close.onclick = function(){
    modal.style.display = 'none';
  }
  window.onclick = function(event){
    if(event.target.className == 'modal-background'){
      modal.style.display = 'none';
    }
  }