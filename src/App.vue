<script setup>
	import HeaderMain from './components/HeaderMain.vue';
	import ScrollHome from './components/ScrollHome.vue';
	import ApresentationHome from './components/ApresentationHome.vue';
	import FooterMain from './components/FooterMain.vue';
</script>

<template>
	<div>
		<ApresentationHome />
		<HeaderMain />
		<ScrollHome />
		<FooterMain />
  	</div>
</template>

<style>
	@import url('https://fonts.googleapis.com/css2?family=Advent+Pro:wght@500;600;700&display=swap');
	*{
		font-family: 'Advent Pro' !important;
	}
	#app {
		-webkit-font-smoothing: antialiased;
		-moz-osx-font-smoothing: grayscale;
		text-align: center;
		color: #2c3e50;
	}

	/* 	 Butões	  */
    header button.login, header button.cadastro, div#fakehead button.login,div#fakehead button.cadastro{
        color: white;
        border-radius: 30px;
        border-color: transparent;
        font-size: 23px;
        width: 165px;
        height: 50px;
    }
    button.cadastro{
        background-color: #06D148;
        box-shadow: 0 5px #05B056;
        margin-bottom: 10px;
    }
    button.login{
        background-color: #003CC7;
        box-shadow: 0 5px #013ABE;
    }
    button.cadastro:hover{
        background-color: #02ed4e;
        box-shadow: 0 5px #06D148; 
    }
    button.login:hover{
        background-color: #0242d6;
        box-shadow: 0 5px #003CC7;
    }
    button{
        cursor: pointer;
        outline: none;
    }
    button.cadastro:active, button.login:active{
        transform: translateY(5px);
        box-shadow: none;
    }

</style>
