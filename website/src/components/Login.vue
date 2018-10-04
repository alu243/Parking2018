<template>
  <v-layout row class="text-xs-center">
    <v-flex xs4 style="background-image: url('https://cdn.wallpapersafari.com/7/86/gqiGH7.jpg')">
    </v-flex>
    <v-flex xs8>
      <v-card flat>
        <v-card-title primary-title>
          <h4>登入</h4>
        </v-card-title>
        <v-form>
          <v-text-field prepend-icon="person" name="Username" label="帳號"></v-text-field>
          <v-text-field prepend-icon="lock" name="Password" label="密碼" type="password"></v-text-field>
          <v-card-actions>
            <v-btn primary large block @click.stop="dialog = false">登 入
              <v-icon>input</v-icon>
            </v-btn>
          </v-card-actions>
        </v-form>
      </v-card>
    </v-flex>
  </v-layout>
</template>

<script>
export default {
	name: 'Login'
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
