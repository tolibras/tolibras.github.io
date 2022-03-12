<template>
    <header id="head">
        <picture>
            <img src="/imagens/LogoP.svg" alt="">
        </picture>
        <div>
            <button class="cadastro" @click="redirectPage('Novaconta.html')">Criar conta</button><br>
            <button class="login">Já tenho</button>
        </div>
    </header>
</template>

<style scoped>

    #head{
        background-color: #002D94;
        display: flex !important;
        align-items: center;
        justify-content: space-around;
        color: white;
        padding: 1em;
    }
    header#head button.cadastro{
        margin-right: 10px;
    }
    /* header#head{
        visibility: hidden;
        width: -webkit-fill-available;
        top: 0;
        position: fixed;
    } */
    header div{
        display: flex;
    }
    .sticky {
        position: fixed;
        top: 0;
        width: 100%
    }
    .scrollhome {
  padding: 16px;
}
    .sticky + .scrollhome {
        padding-top: 102px;
    }

</style>

<script>
    export default {
        name: "HeaderMain",
        data(){
            return{
                header: null,
                sticky: null,
                link: null
            }
        },
        mounted(){
            window.addEventListener('scroll', this.stikyHead);
            this.header = document.getElementById("head");
            this.sticky = this.header.offsetTop + 5;
        },
        methods:{
            stikyHead(){
                if(window.pageYOffset > this.sticky){
                    this.header.classList.add('sticky');
                }
                else {
                    this.header.classList.remove("sticky");
                    console.log(this.sticky);
                }
            },
            redirectPage(url){
                window.location.assign(url);
            }
        }
    }
</script>