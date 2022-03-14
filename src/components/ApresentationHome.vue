<template>
    <section class="home">
        <picture>
            <img src="/imagens/LogoG.svg" alt="">
        </picture>
        <h2>Olá! Esteja à vontade para aprender a Lingua Brasileira de Sinais<br>em nossa plataforma.</h2>
        <div>
            <button class="cadastro" onclick="window.location.assign('Novaconta.html')">Criar conta</button><br>
            <button class="login">Já tenho</button>
        </div>
    </section>
</template>

<style scoped>
    /* 	 Section de apresentação   */
	section.home{
		background-image: url(../imagens/Apresentacao.png);
		background-repeat: no-repeat;
		background-size: 100%;
		color: white;
		text-align: center;
	}
	section h1{
		padding-top: 2em;
	}
	section.home h2{
		font-size: 33px;
		margin-top: 60px;
		font-weight: 600;
	}
	section.home img{
		padding-top: 20px;
	}
	section.home div{
		margin-top: 30px;
		padding-bottom: 17em;
	}
	div.modal-card a{
		text-decoration: underline;
		color:#8C8C8C;
	}
    section.home button.login, section.home button.cadastro{
        color: white;
        border-radius: 30px;
        border-color: transparent;
        font-size: 25px;
        width: 200px;
        height: 50px;
        font-weight: 700;
    }
</style>

<script>
export default {
    name: "ApresentationHome"
}
</script>
