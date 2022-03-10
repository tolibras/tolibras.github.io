<template>
    <section class="scrollhome">
        <div class="modal" id="page-modal">
            <div class="modal-background"></div>
            <div class="modal-card">
                <header class="modal-card-head">
                    <p class="modal-card-title">Entrar</p>
                    <button class="delete" aria-label="close"></button>
                </header>
                <section class="modal-card-body">
                    <div class="field">
                        <p class="control has-icons-left has-icons-right">
                            <input class="input is-rounded" type="email" placeholder="Email">
                            <span class="icon is-small is-left">
                                <i class="fas fa-envelope"></i>
                            </span>
                            <span class="icon is-small is-right">
                                <i class="fas fa-check"></i>
                            </span>
                        </p>
                    </div>
                    <div class="field">
                        <p class="control has-icons-left">
                            <input class="input is-rounded" type="password" placeholder="Password">
                            <span class="icon is-small is-left">
                                <i class="fas fa-lock"></i>
                            </span>
                        </p>
                    </div>
                    <a href="#">Esqueceu a senha</a>
                </section>
                <footer class="modal-card-foot">
                    <button onclick="window.location.assign('Paginicial.html')" class="button is-primary is-fullwidth">
                        Login
                    </button>
                </footer>
            </div>
        </div>
        <div id="frd">
            <div class="boxinfo">
                <h2 class="title">Lorem</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
                cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
                proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            </div>
        </div>
        <figure>
            <img class="boxinfo" id="fr" src="imagens/FormacaoToLIBRAS.svg" alt="">
        </figure>
        <div id="fld">
            <div class="boxinfo">
                <h2 class="title">Lorem</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
                cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
                proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            </div>
        </div>
    </section>
</template>

<style scoped>
    /* 	 Section scrollhome	  */
	section.scrollhome{
		margin: 10em;
	}
	img.boxinfo{
		height: 8em;
		margin: 6em 0;
	}
	div.boxinfo{
		text-align: center;
	}
	section.scrollhome figure{
		text-align: center;
	}
	.boxinfo p{
		font-size: 18px;
		font-weight: 600;
	}
	div#page-modal{
		display: none;
	}
</style>

<script>
export default {
    name: "ScrollHome"
}
</script>