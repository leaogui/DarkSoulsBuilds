namespace DarkSoulsBuilds
{
    public class Atributos
    {


        private int ft, inte, dex, str, vgr, sta, vit, attn, lck, hollow;

        public Atributos(int ft,int inte, int dex, int str, int vgr, int sta, int vit, int attn, int lck, int hollow){
            this.ft = ft;
            this.inte = inte;
            this.dex = dex;
            this.str = str;
            this.vgr =vgr;
            this.sta = sta;
            this.vit = vit;
            this.attn = attn;
            this.lck = lck;
            this.hollow = hollow
            ;


        }


	public int getFt() {
		return this.ft;
	}

    public int getInte() {
		return this.inte;
	}

    public int getDex() {
		return this.dex;
	}

    public int getStr() {
		return this.str;
	}

    public int getVgr() {
		return this.vgr;
	}

    public int getSta() {
		return this.sta;
	}

    public int getVit() {
		return this.vit;
	}

    public int getAttn() {
		return this.attn;
	}

    public int getLck() {
		return this.lck;
	}

    public int getHollow() {
		return this.hollow;
	}

	public void setFt(int ft) {
		this.ft = ft;
	}

    public void setInte(int inte) {
		this.inte = inte;
	}

    public void setDex(int dex) {
		this.dex = dex;
	}

    public void setStr(int str) {
		this.str = str;
	}

    public void setVgr(int vgr) {
		this.vgr = vgr;
	}

    public void setSta(int sta) {
		this.sta = sta;
	}

    public void setVit(int vit) {
		this.vit = vit;
	}

    public void setAttn(int attn) {
		this.attn = attn;
	}

    public void setLck(int lck) {
		this.lck = lck;
	}

    public void setHollow(int hollow) {
		this.hollow = hollow;
	}

        void removeHollow(){

            this.hollow = 0;        
            }


    }
}