<template>
    <footer>
		<h3>Todos os direitos reservados 2XXX©</h3>
		<div id="img">
			<a href="https://instagram.com/ToLIBRAS">
				<picture id="insta">
					<img src="/imagens/insta.svg" alt="">
				</picture>
			</a>
			<a href="https://twitter.com/ToLIBRAS">
				<picture id="twitter">
					<img src="/imagens/twitter.svg" alt="">
				</picture>
			</a>
			<a href="https://facebook.com/ToLIBRAS">
				<picture id="face">
					<img src="/imagens/face.svg" alt="">
				</picture>
			</a>
		</div>
	</footer>
</template>

<style scoped>
    footer{
        background-color: #002D94;
        display:flex !important;
        align-items: center;
        justify-content: space-between;
        padding: 2em;
        color: white;
    }
    footer div#img{
        display: inline;
    }
    footer picture{
        text-align: center;
        padding: 0 1em;
    }
    footer h3{
        font-weight: 500 !important;
    }
</style>

<script>
export default {
    name: "FooterMain"
}
</script>