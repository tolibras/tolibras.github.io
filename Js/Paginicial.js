/*   Paginicial   */
var slider = document.getElementsByClassName("scroll")[0];
  let isDown = false;
  let startY;
  let startX;
  let scrollTop;
  let scrollLeft;

  slider.addEventListener("mousedown", (e) => {
    isDown = true;
    startY = e.pageY - slider.offsetTop;
    // startX = e.pageX - slider.offsetLeft;
    scrollTop = slider.scrollTop;
    // scrollLeft = slider.scrollLeft;
    console.log(scrollTop);
  });
  slider.addEventListener("mouseleave", () => {
    isDown = false;
  });
  slider.addEventListener("mouseup", () => {
    isDown = false;
  });
  slider.addEventListener("mousemove", (e) => {
    if (!isDown) return;
    e.preventDefault();
    const y = e.pageY - slider.offsetTop;
    // const x = e.pageX - slider.offsetLeft;
    const walk = y - startY;
    // const walk1 = x -startX;
    slider.scrollTop = scrollTop - walk;
    // slider.scrollLeft = scrollLeft - walk1;
    console.log(slider.scrollTop+" = "+scrollTop+" - "+walk);
  });


  function scala(event){
  var drag = document.getElementById("drag");
  var delta;
    if (event.wheelDelta){
      delta = event.wheelDelta;
    }
    else{
      delta = -1 *event.deltaY;
    }

  if (delta < 0){
      drag.style.transform = "scale("+0.5+","+0.5+")";
      slider.style.height = 100+"%";
    }
    else if (delta > 0){
      drag.style.transform = "scale("+1+","+1+")";
      slider.style.height = 100+"%";
    }
}