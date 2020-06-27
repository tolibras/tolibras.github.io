function fixarHead() {
  var posy = pageYOffset;
  var head = document.getElementById("head");
  	if(screen.width >= 1281 && screen.width <= 1500){
  		if(posy>=710){
  			head.style.visibility = "visible";
  		}
  		else{
  			head.style.visibility = "hidden";
  		}
	}
	else if(screen.width >=1750 && screen.width <=1920){
		if(posy>=652){
  			head.style.visibility = "visible";
  		}
  		else{
  			head.style.visibility = "hidden";
  		}
	}
	else if(screen.width <=1280){
		if(posy>=665){
  			head.style.visibility = "visible";
  		}
  		else{
  			head.style.visibility = "hidden";
  		}
	}
}
function placeholder(img,num){
	var ph = null;
	var x = $(img).position();
	console.log(x.top);
	console.log(x.left);
	if(num == 1){
		if(img.id == "insta"){
			ph = document.getElementById("placeh1");
			ph.style.display = "block";
			ph.style.position = "absolute";
			ph.style.top = (x.top-50)+"px";
			ph.style.left = (x.left-12)+"px";
			ph.style.visibility = "visible";
			
		}
		else if(img.id == "face"){
			ph = document.getElementById("placeh3");
			ph.style.display = "block";
			ph.style.position = "absolute";
			ph.style.top = (x.top-50)+"px";
			ph.style.left = (x.left-12)+"px";
			ph.style.visibility = "visible";		
		}
		else if(img.id == "twitter"){
			ph = document.getElementById("placeh2");
			ph.style.display = "block";
			ph.style.position = "absolute";
			ph.style.top = (x.top-50)+"px";
			ph.style.left = (x.left-10)+"px";
			ph.style.visibility = "visible";
		}
	}
	else{
		if(img.id == "insta"){
			ph = document.getElementById("placeh1");
			ph.style.visibility = "hidden";
		}
		else if(img.id == "face"){
			ph = document.getElementById("placeh3");
			ph.style.visibility = "hidden";
		}
		else if(img.id == "twitter"){
			ph = document.getElementById("placeh2");
			ph.style.visibility = "hidden";

		}
	}
}