<template>
  <v-form ref="form" v-model="valid" lazy-validation>
    <v-container fluid>
      <v-layout row wrap>
        <v-flex xs6 sm6 md3>
          <v-autocomplete v-model="model" :items="states" label="停車管理員" prepend-icon="person" />
        </v-flex>
        <v-flex xs6 sm6 md3>
          <v-text-field v-model="name" :rules="nameRules" label="車號" prepend-icon="directions_car" required />
        </v-flex>
        <v-flex xs6 sm6 md3>
          <v-datetime-picker label="時間起值" v-model="date" prepend-icon="event"> </v-datetime-picker>
        </v-flex>
        <v-flex xs6 sm6 md3>
          <v-datetime-picker label="時間訖值" v-model="date"> </v-datetime-picker>
        </v-flex>
        <v-flex xs6 sm6 md6>
          <v-btn small :disabled="!valid" @click="submit">
            <v-icon>search</v-icon>
            查詢
          </v-btn>
          <v-btn small @click="clear">
            <v-icon>clear</v-icon>
            清除
          </v-btn>
        </v-flex>
      </v-layout>
    </v-container>
  </v-form>
</template>
        <!-- <v-text-field v-model="email" :rules="emailRules" label="E-mail" required></v-text-field>
      <v-select v-model="select" :items="items" :rules="[v => !!v || 'Item is required']" label="Item" required></v-select>
      <v-checkbox v-model="checkbox" :rules="[v => !!v || 'You must agree to continue!']" label="Do you agree?" required></v-checkbox> -->

<script>
export default {
	name: 'BillSearch',
	props: {
		msg: String
	},
	data() {
		return {
			model: null,
			states: ['王大明', '王小明', '李大雄', '葉小華']
		}
	}
}
</script>